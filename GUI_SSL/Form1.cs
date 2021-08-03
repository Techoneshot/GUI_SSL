using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_SSL
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();

        }
        private static List<string> FilesFound { get; } = new List<string>();
        private const string SearchText = "*.exe";
        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog inputDialog = new OpenFileDialog();
            inputDialog.Title = "Wskaż swój certyfikat";
            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
                certPathTextbox.Text = inputDialog.FileName.ToString();
                textBoxExtension.Text = Path.GetExtension(inputDialog.FileName.ToString());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (splitCheckbox.Checked == false)
            {
                SaveFileDialog outputDialog = new SaveFileDialog();
                outputDialog.Title = "Gdzie zapisać po konwersji?";
                outputDialog.DefaultExt = ".pem";
                if (outputDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxOutput.Text = outputDialog.FileName.ToString();
                }
            }
            else
            {
                FolderBrowserDialog outputDialog = new FolderBrowserDialog();
                outputDialog.Description = "Gdzie zapisać po konwersji?";
                if (outputDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxOutput.Text = outputDialog.SelectedPath.ToString();
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveParametersCheckbox.Checked == true)
                {
                    Properties.Settings.Default.Save();
                }
                else if (saveParametersCheckbox.Checked == false)
                {
                    Properties.Settings.Default.outputPath = "";
                    Properties.Settings.Default.saveParameters = false;
                    Properties.Settings.Default.certPath = "";
                    Properties.Settings.Default.Save();
                }
                Process process = new Process();
                process.StartInfo.FileName = Properties.Settings.Default.OpenSSLPath;
                process.StartInfo.CreateNoWindow = false;
                process.StartInfo.UseShellExecute = false;
                if (textBoxExtension.Text == ".pfx" && splitCheckbox.Checked == false)
                { process.StartInfo.Arguments = @"pkcs12 -in " + certPathTextbox.Text + " -out " + textBoxOutput.Text + " -nodes  -password pass:" + certPassTextbox.Text; }
                else if (textBoxExtension.Text == ".pfx" && splitCheckbox.Checked == true)
                { 
                    //cert
                    process.StartInfo.Arguments = $@"pkcs12 -in {certPathTextbox.Text} -out {textBoxOutput.Text}\cert.pem -nodes -clcerts -nokeys -password pass:{certPassTextbox.Text}";
                    process.Start();
                    process.WaitForExit();
                    process.StartInfo.Arguments = $@"x509 -in {textBoxOutput.Text}\cert.pem -out {textBoxOutput.Text}\cert.pem";
                    process.Start();
                    process.WaitForExit();
                    //root
                    process.StartInfo.Arguments = $@"pkcs12 -in {certPathTextbox.Text} -out {textBoxOutput.Text}\root.pem -nodes -cacerts -nokeys -password pass:{certPassTextbox.Text}";
                    process.Start();
                    process.WaitForExit();
                    process.StartInfo.Arguments = $@"x509 -in {textBoxOutput.Text}\root.pem -out {textBoxOutput.Text}\root.pem";
                    process.Start();
                    process.WaitForExit();
                    //key
                    process.StartInfo.Arguments = $@"pkcs12 -in {certPathTextbox.Text} -out {textBoxOutput.Text}\key.pem -nodes -nocerts -password pass:{certPassTextbox.Text}";
                    process.Start();
                    process.WaitForExit();
                    process.StartInfo.Arguments = $@"x509 -in {textBoxOutput.Text}\key.pem -out {textBoxOutput.Text}\key.pem";
                    process.Start();
                    process.WaitForExit();
                }
                if (textBoxExtension.Text == ".p7b")
                { process.StartInfo.Arguments = @"pkcs7 -in " + certPathTextbox.Text + " -inform DER -print_certs -out " + textBoxOutput.Text; }
                if (textBoxExtension.Text == ".cer" | textBoxExtension.Text == ".der")
                { process.StartInfo.Arguments = @"x509 -inform der -in " + certPathTextbox.Text + " -out " + textBoxOutput.Text; }
                if (textBoxExtension.Text == ".crt")
                { process.StartInfo.Arguments = @"x509 -in " + certPathTextbox.Text + " -out " + textBoxOutput.Text + " -outform PEM"; }
                process.Start();
                process.WaitForExit();
                //inspectButton.Visible = true;
                //string outputFolder = Path.GetDirectoryName(textBoxOutput.Text);
                //process.StartInfo.Arguments = $@"pkey -in {textBoxOutput} -out C:\Users\techo\Desktop\temp.pem";
                process.Start();
                process.WaitForExit();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Wskaż lokalizację OpenSSL.exe", "Brak pliku", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Properties.Settings.Default.Save();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Wskaż lokalizację OpenSSL.exe";
            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                openSSLLocationTextbox.Text = fileOpen.FileName.ToString();
            }
            Properties.Settings.Default.Save();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://slproweb.com/products/Win32OpenSSL.html");
        }
        private static void DirSearch(string sDir)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                foreach (var directory in Directory.GetDirectories(sDir))
                {
                    foreach (var filename in Directory.GetFiles(directory))
                    {
                        using (var streamReader = new StreamReader(filename))
                        {
                            var contents = streamReader.ReadToEnd().ToLower();

                            if (contents.Contains(SearchText))
                            {
                                FilesFound.Add(filename);
                            }
                        }
                    }

                    DirSearch(directory);
                }
                Cursor.Current = Cursors.Default;
            }
            catch (System.Exception ex)
            {
                Cursor.Current = Cursors.Default;
                Console.WriteLine(ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible == true)
            {
                listBox1.Visible = false;
            }
            else
            {
                listBox1.Visible = true;
            }
        }

        private void listBox1_VisibleChanged(object sender, EventArgs e)
        {
            if (listBox1.Visible == true)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    listBox1.Visible = true;
                    searchButton.Image = Properties.Resources.delete2;
                    toolTip1.Show("Zamknij", searchButton);
                    Application.DoEvents();
                    listBox1.Items.Clear();
                    listBox1.DataSource = GetFiles(@"C:\", "openSSL.exe");
                    Cursor.Current = Cursors.Default;
                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                searchButton.Image = Properties.Resources.search;
                toolTip1.Show("Szukaj", searchButton);
            }
        }

        private List<string> GetFiles(string path, string pattern)
        {
            var files = new List<string>();
            var directories = new string[] { };

            try
            {
                files.AddRange(Directory.GetFiles(path, pattern, SearchOption.TopDirectoryOnly));
                directories = Directory.GetDirectories(path);
            }
            catch (UnauthorizedAccessException) { }
            catch (DirectoryNotFoundException) { }

            foreach (var directory in directories)
                try
                {
                    files.AddRange(GetFiles(directory, pattern));
                }
                catch (UnauthorizedAccessException) { }
                catch (DirectoryNotFoundException) { }

            return files;
        }



        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = this.listBox1.IndexFromPoint(e.Location);
                openSSLLocationTextbox.Text = listBox1.Items[index].ToString();
                listBox1.Visible = false;
                Properties.Settings.Default.Save();
            }
            catch (Exception)
            {

            }
            
        }

        private void inspectButton_Click(object sender, EventArgs e)
        {
            InspectForm inspectForm = new InspectForm();
            inspectForm.Icon = this.Icon;
            inspectForm.certFile = textBoxOutput.Text;
            inspectForm.richTextBox1.Text = File.ReadAllText(textBoxOutput.Text);
            inspectForm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(Path.GetDirectoryName(textBoxOutput.Text));
        }

        private void textBoxExtension_TextChanged(object sender, EventArgs e)
        {
            if (textBoxExtension.Text == ".pfx")
            {
                splitCheckbox.Visible = true;
                certPassTextbox.Visible = true;
                label4.Visible = true;
            }
            else
            {
                splitCheckbox.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            certPathTextbox.Text = Properties.Settings.Default.certPath;
            textBoxExtension.Text = Path.GetExtension(certPathTextbox.Text);
        }

    }
}
