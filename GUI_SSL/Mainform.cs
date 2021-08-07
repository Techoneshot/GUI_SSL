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
using System.Threading;
using System.Globalization;

namespace GUI_SSL
{
    public partial class MainForm : Form

    {
        public MainForm()
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
                if (PEMradioButton.Checked == true)
                {
                    outputDialog.DefaultExt = ".pem";
                }
                if (DERradioButton.Checked == true)
                {
                    outputDialog.DefaultExt = ".der";
                }
                if (P7BradioButton.Checked == true)
                {
                    outputDialog.DefaultExt = ".p7b";
                }
                if (PFXradioButton.Checked == true)
                {
                    outputDialog.DefaultExt = ".pfx";
                }

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
                    Properties.Settings.Default.OutputPath = "";
                    Properties.Settings.Default.SaveParameters = false;
                    Properties.Settings.Default.CertPath = "";
                    Properties.Settings.Default.Save();
                }
                Process process = new Process();
                process.StartInfo.FileName = Properties.Settings.Default.OpenSSLPath;
                process.StartInfo.CreateNoWindow = false;
                process.StartInfo.UseShellExecute = false;
                //PEM
                if (PEMradioButton.Checked == true)
                {
                    if (textBoxExtension.Text == ".pfx")
                    {
                        if (textBoxExtension.Text == ".pfx" && splitCheckbox.Checked == false)
                        { 
                            process.StartInfo.Arguments = $@"pkcs12 -in {certPathTextbox.Text} -out {textBoxOutput.Text} -nodes -password pass:{certPassTextbox.Text}"; 
                        }
                        else if (textBoxExtension.Text == ".pfx" && splitCheckbox.Checked == true)
                        {
                            //cert
                            process.StartInfo.Arguments = $@"pkcs12 -in {certPathTextbox.Text} -out {textBoxOutput.Text}\cert.pem -nodes -clcerts -nokeys -password pass:{certPassTextbox.Text}";
                            process.Start();
                            process.WaitForExit();
                            if (removeBagCheckbox.Checked == true)
                            {
                                var oldLines = System.IO.File.ReadAllLines(textBoxOutput.Text + @"\cert.pem");
                                var newLines = oldLines.Where(line => !line.Contains("Attributes"));
                                newLines = newLines.Where(line => !line.Contains("friendlyName"));
                                newLines = newLines.Where(line => !line.Contains("localKeyID"));
                                newLines = newLines.Where(line => !line.Contains("subject"));
                                newLines = newLines.Where(line => !line.Contains("issuer"));
                                System.IO.File.WriteAllLines(textBoxOutput.Text + @"\cert.pem", newLines);
                            }
                            //root
                            process.StartInfo.Arguments = $@"pkcs12 -in {certPathTextbox.Text} -out {textBoxOutput.Text}\root.pem -nodes -cacerts -nokeys -password pass:{certPassTextbox.Text}";
                            process.Start();
                            process.WaitForExit();
                            if (removeBagCheckbox.Checked == true)
                            {
                                var oldLines = System.IO.File.ReadAllLines(textBoxOutput.Text + @"\root.pem");
                                var newLines = oldLines.Where(line => !line.Contains("Attributes"));
                                newLines = newLines.Where(line => !line.Contains("friendlyName"));
                                newLines = newLines.Where(line => !line.Contains("localKeyID"));
                                newLines = newLines.Where(line => !line.Contains("subject"));
                                newLines = newLines.Where(line => !line.Contains("issuer"));
                                System.IO.File.WriteAllLines(textBoxOutput.Text + @"\root.pem", newLines);
                            }
                            //key
                            process.StartInfo.Arguments = $@"pkcs12 -in {certPathTextbox.Text} -out {textBoxOutput.Text}\key.pem -nodes -nocerts -password pass:{certPassTextbox.Text}";
                            process.Start();
                            process.WaitForExit();
                            if (removeBagCheckbox.Checked == true)
                            {
                                var oldLines = System.IO.File.ReadAllLines(textBoxOutput.Text + @"\key.pem");
                                var newLines = oldLines.Where(line => !line.Contains("Attributes"));
                                newLines = newLines.Where(line => !line.Contains("friendlyName"));
                                newLines = newLines.Where(line => !line.Contains("localKeyID"));
                                newLines = newLines.Where(line => !line.Contains("subject"));
                                newLines = newLines.Where(line => !line.Contains("issuer"));
                                System.IO.File.WriteAllLines(textBoxOutput.Text + @"\key.pem", newLines);
                            }
                            return;
                        }
                    }
                    if (textBoxExtension.Text == ".p7b" && PEMradioButton.Checked == true)
                    {
                        process.StartInfo.Arguments = @"pkcs7 -in " + certPathTextbox.Text + " -inform DER -print_certs -out " + textBoxOutput.Text;
                    }
                    if ((textBoxExtension.Text == ".cer" | textBoxExtension.Text == ".der" | textBoxExtension.Text == ".crt") && PEMradioButton.Checked == true)
                    {
                        process.StartInfo.Arguments = @"x509 -inform der -in " + certPathTextbox.Text + " -out " + textBoxOutput.Text;
                    }
                    process.Start();
                    process.WaitForExit();
                    if (removeBagCheckbox.Checked == true)
                    {
                        var oldLines = System.IO.File.ReadAllLines(textBoxOutput.Text);
                        var newLines = oldLines.Where(line => !line.Contains("Attributes"));
                        newLines = newLines.Where(line => !line.Contains("friendlyName"));
                        newLines = newLines.Where(line => !line.Contains("localKeyID"));
                        newLines = newLines.Where(line => !line.Contains("subject"));
                        newLines = newLines.Where(line => !line.Contains("issuer"));
                        System.IO.File.WriteAllLines(textBoxOutput.Text, newLines);
                    }
                }
                if (DERradioButton.Checked == true)
                {
                    if (textBoxExtension.Text == ".pem")
                    {
                        process.StartInfo.Arguments = $@"x509 -outform der -in {certPathTextbox} -out {textBoxOutput}";
                        process.Start();
                        process.WaitForExit();
                    }
                }
                //if (P7BradioButton.Checked == true)
                //{
                //    if (textBoxExtension.Text == ".pem")
                //    {
                //        process.StartInfo.Arguments = $@"x509 -outform der -in {certPathTextbox} -out {textBoxOutput}";
                //        process.Start();
                //        process.WaitForExit();
                //    }
                //}
                //if (PFXradioButton.Checked == true)
                //{
                //    if (textBoxExtension.Text == ".pem")
                //    {
                //        process.StartInfo.Arguments = $@"x509 -outform der -in {certPathTextbox} -out {textBoxOutput}";
                //        process.Start();
                //        process.WaitForExit();
                //    }
                //}
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

        private void textBoxExtension_TextChanged(object sender, EventArgs e)
        {
            if (textBoxExtension.Text == ".pfx")
            {
                splitCheckbox.Visible = true;
                removeBagCheckbox.Visible = true;
                certPassTextbox.Visible = true;
                label4.Visible = true;
                PEMradioButton.Enabled = true;
                DERradioButton.Enabled = false;
                P7BradioButton.Enabled = false;
                PFXradioButton.Enabled = false;
            }
            if (textBoxExtension.Text == ".pem")
            {
                splitCheckbox.Visible = false;
                splitCheckbox.Checked = false;
                removeBagCheckbox.Visible = false;
                removeBagCheckbox.Checked = false;
                certPassTextbox.Visible = false;
                label4.Visible = false;
                PEMradioButton.Enabled = false;
                DERradioButton.Enabled = true;
                P7BradioButton.Enabled = false;
                PFXradioButton.Enabled = false;
            }
            else
            {
                splitCheckbox.Visible = false;
                splitCheckbox.Checked = false;
                removeBagCheckbox.Visible = false;
                removeBagCheckbox.Checked = false;
                certPassTextbox.Visible = false;
                label4.Visible = false;
                PEMradioButton.Enabled = false;
                DERradioButton.Enabled = false;
                P7BradioButton.Enabled = false;
                PFXradioButton.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            certPathTextbox.Text = Properties.Settings.Default.CertPath;
            textBoxExtension.Text = Path.GetExtension(certPathTextbox.Text);
        }

        private void ButtonPL_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("pl-PL");
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;
            System.Threading.Thread.CurrentThread.CurrentUICulture = ci;
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void buttonUS_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;
            System.Threading.Thread.CurrentThread.CurrentUICulture = ci;
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void buttonDE_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("de");
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;
            System.Threading.Thread.CurrentThread.CurrentUICulture = ci;
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void File_Drag_Drop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            (sender as TextBox).Text = filePaths[0];
        }

        private void File_Drag_Enter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
