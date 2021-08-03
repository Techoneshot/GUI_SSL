namespace GUI_SSL
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label4 = new System.Windows.Forms.Label();
            this.certPassTextbox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitCheckbox = new System.Windows.Forms.CheckBox();
            this.saveParametersCheckbox = new System.Windows.Forms.CheckBox();
            this.openSSLLocationTextbox = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.certPathTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hasło do certyfikatu:";
            this.label4.Visible = false;
            // 
            // certPassTextbox
            // 
            this.certPassTextbox.Location = new System.Drawing.Point(329, 87);
            this.certPassTextbox.Name = "certPassTextbox";
            this.certPassTextbox.PasswordChar = '*';
            this.certPassTextbox.Size = new System.Drawing.Size(121, 20);
            this.certPassTextbox.TabIndex = 20;
            this.certPassTextbox.Visible = false;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startButton.Location = new System.Drawing.Point(339, 158);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(111, 23);
            this.startButton.TabIndex = 19;
            this.startButton.Text = "KONWERTUJ";
            this.startButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 24);
            this.button2.TabIndex = 18;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Enabled = false;
            this.textBoxExtension.Location = new System.Drawing.Point(164, 87);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(47, 20);
            this.textBoxExtension.TabIndex = 17;
            this.textBoxExtension.TextChanged += new System.EventHandler(this.textBoxExtension_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Format certyfikatu:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(414, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 24);
            this.button1.TabIndex = 15;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Gdzie chcesz zapisać:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Wskaż lokalizację certyfikatu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Lokalizacja OpenSSL.exe:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(45, 32);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 13);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "(Pobierz OpenSSL)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Location = new System.Drawing.Point(414, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 24);
            this.button4.TabIndex = 25;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // searchButton
            // 
            this.searchButton.Image = global::GUI_SSL.Properties.Resources.search;
            this.searchButton.Location = new System.Drawing.Point(452, 14);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(24, 24);
            this.searchButton.TabIndex = 26;
            this.toolTip1.SetToolTip(this.searchButton, "Szukaj");
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(438, 56);
            this.listBox1.TabIndex = 27;
            this.listBox1.Visible = false;
            this.listBox1.VisibleChanged += new System.EventHandler(this.listBox1_VisibleChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // splitCheckbox
            // 
            this.splitCheckbox.AutoSize = true;
            this.splitCheckbox.Checked = true;
            this.splitCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.splitCheckbox.Location = new System.Drawing.Point(164, 113);
            this.splitCheckbox.Name = "splitCheckbox";
            this.splitCheckbox.Size = new System.Drawing.Size(147, 17);
            this.splitCheckbox.TabIndex = 29;
            this.splitCheckbox.Text = "Rozdziel na cert/root/key";
            this.splitCheckbox.UseVisualStyleBackColor = true;
            this.splitCheckbox.Visible = false;
            // 
            // saveParametersCheckbox
            // 
            this.saveParametersCheckbox.AutoSize = true;
            this.saveParametersCheckbox.Checked = global::GUI_SSL.Properties.Settings.Default.saveParameters;
            this.saveParametersCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GUI_SSL.Properties.Settings.Default, "saveParameters", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.saveParametersCheckbox.Location = new System.Drawing.Point(164, 162);
            this.saveParametersCheckbox.Name = "saveParametersCheckbox";
            this.saveParametersCheckbox.Size = new System.Drawing.Size(113, 17);
            this.saveParametersCheckbox.TabIndex = 30;
            this.saveParametersCheckbox.Text = "Zapamiętaj ścieżki";
            this.saveParametersCheckbox.UseVisualStyleBackColor = true;
            // 
            // openSSLLocationTextbox
            // 
            this.openSSLLocationTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GUI_SSL.Properties.Settings.Default, "OpenSSLPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.openSSLLocationTextbox.Location = new System.Drawing.Point(164, 16);
            this.openSSLLocationTextbox.Name = "openSSLLocationTextbox";
            this.openSSLLocationTextbox.Size = new System.Drawing.Size(250, 20);
            this.openSSLLocationTextbox.TabIndex = 24;
            this.openSSLLocationTextbox.Text = global::GUI_SSL.Properties.Settings.Default.OpenSSLPath;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GUI_SSL.Properties.Settings.Default, "outputPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxOutput.Location = new System.Drawing.Point(164, 136);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(250, 20);
            this.textBoxOutput.TabIndex = 13;
            this.textBoxOutput.Text = global::GUI_SSL.Properties.Settings.Default.outputPath;
            // 
            // certPathTextbox
            // 
            this.certPathTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GUI_SSL.Properties.Settings.Default, "certPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.certPathTextbox.Location = new System.Drawing.Point(164, 61);
            this.certPathTextbox.Name = "certPathTextbox";
            this.certPathTextbox.Size = new System.Drawing.Size(250, 20);
            this.certPathTextbox.TabIndex = 12;
            this.certPathTextbox.Text = global::GUI_SSL.Properties.Settings.Default.certPath;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 189);
            this.Controls.Add(this.saveParametersCheckbox);
            this.Controls.Add(this.splitCheckbox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.openSSLLocationTextbox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.certPassTextbox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.certPathTextbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenSLL GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox certPassTextbox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox certPathTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox openSSLLocationTextbox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox textBoxOutput;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox splitCheckbox;
        private System.Windows.Forms.CheckBox saveParametersCheckbox;
    }
}

