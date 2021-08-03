using System;
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
    public partial class InspectForm : Form
    {
        public string certFile;
        public InspectForm()
        {
            InitializeComponent();
        }

        private void InspectForm_Shown(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText(certFile).ToString();
            string tempCertFile = Path.GetDirectoryName(certFile) + @"\temp_cert.pem";
            string tempRootFile = Path.GetDirectoryName(certFile) + @"\temp_root.pem";
            string tempKeyFile = Path.GetDirectoryName(certFile)+ @"\temp_key.pem";
            //cert
            Process process = new Process();
            process.StartInfo.FileName = Properties.Settings.Default.OpenSSLPath;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = $@"x509 -in {certFile} -outform PEM -out {tempCertFile}";
            process.Start();
            process.WaitForExit();
            certRichTextBox.Text = File.ReadAllText(tempCertFile).ToString();
            //Key
            process = new Process();
            process.StartInfo.FileName = Properties.Settings.Default.OpenSSLPath;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = $@"pkey -in {certFile} -out {tempKeyFile}";
            process.Start();
            process.WaitForExit();
            richTextBox1.Text = File.ReadAllText(certFile);
            keyRichTextBox.Text = File.ReadAllText(tempKeyFile);
            //root
            process = new Process();
            process.StartInfo.FileName = Properties.Settings.Default.OpenSSLPath;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.UseShellExecute = false;
            //process.StartInfo.Arguments = $@"crl2pkcs7 -nocrl -certfile {certFile} | openssl pkcs7 -print_certs -out {tempRootFile}";
            process.StartInfo.Arguments = $@"x509 -in {certFile} -outform EPM -cacert -out {tempRootFile}";
            process.Start();
            process.WaitForExit();
            //rootRichTextBox.Text = File.ReadAllText(certFile);
            //string root = certFile;
            //root.Replace(File.ReadAllText(keyRichTextBox.Text), "");
            //rootRichTextBox.Text = root;

        }
    }
}
