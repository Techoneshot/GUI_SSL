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
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDE = new System.Windows.Forms.Button();
            this.buttonUS = new System.Windows.Forms.Button();
            this.buttonPL = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitCheckbox = new System.Windows.Forms.CheckBox();
            this.saveParametersCheckbox = new System.Windows.Forms.CheckBox();
            this.openSSLLocationTextbox = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.certPathTextbox = new System.Windows.Forms.TextBox();
            this.removeBagCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PFXradioButton = new System.Windows.Forms.RadioButton();
            this.P7BradioButton = new System.Windows.Forms.RadioButton();
            this.DERradioButton = new System.Windows.Forms.RadioButton();
            this.PEMradioButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // certPassTextbox
            // 
            resources.ApplyResources(this.certPassTextbox, "certPassTextbox");
            this.certPassTextbox.Name = "certPassTextbox";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBoxExtension
            // 
            resources.ApplyResources(this.textBoxExtension, "textBoxExtension");
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.TextChanged += new System.EventHandler(this.textBoxExtension_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // buttonDE
            // 
            this.buttonDE.BackgroundImage = global::GUI_SSL.Properties.Resources.de_flag;
            resources.ApplyResources(this.buttonDE, "buttonDE");
            this.buttonDE.Name = "buttonDE";
            this.toolTip1.SetToolTip(this.buttonDE, resources.GetString("buttonDE.ToolTip"));
            this.buttonDE.UseVisualStyleBackColor = true;
            this.buttonDE.Click += new System.EventHandler(this.buttonDE_Click);
            // 
            // buttonUS
            // 
            this.buttonUS.BackgroundImage = global::GUI_SSL.Properties.Resources.en_US_flag;
            resources.ApplyResources(this.buttonUS, "buttonUS");
            this.buttonUS.Name = "buttonUS";
            this.toolTip1.SetToolTip(this.buttonUS, resources.GetString("buttonUS.ToolTip"));
            this.buttonUS.UseVisualStyleBackColor = true;
            this.buttonUS.Click += new System.EventHandler(this.buttonUS_Click);
            // 
            // buttonPL
            // 
            this.buttonPL.BackgroundImage = global::GUI_SSL.Properties.Resources.pl_PL_flag;
            resources.ApplyResources(this.buttonPL, "buttonPL");
            this.buttonPL.Name = "buttonPL";
            this.toolTip1.SetToolTip(this.buttonPL, resources.GetString("buttonPL.ToolTip"));
            this.buttonPL.UseVisualStyleBackColor = true;
            this.buttonPL.Click += new System.EventHandler(this.ButtonPL_Click);
            // 
            // searchButton
            // 
            this.searchButton.Image = global::GUI_SSL.Properties.Resources.search;
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.Name = "searchButton";
            this.toolTip1.SetToolTip(this.searchButton, resources.GetString("searchButton.ToolTip"));
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            this.listBox1.VisibleChanged += new System.EventHandler(this.listBox1_VisibleChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // splitCheckbox
            // 
            resources.ApplyResources(this.splitCheckbox, "splitCheckbox");
            this.splitCheckbox.Checked = global::GUI_SSL.Properties.Settings.Default.Split;
            this.splitCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.splitCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GUI_SSL.Properties.Settings.Default, "Split", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.splitCheckbox.Name = "splitCheckbox";
            this.splitCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveParametersCheckbox
            // 
            resources.ApplyResources(this.saveParametersCheckbox, "saveParametersCheckbox");
            this.saveParametersCheckbox.Checked = global::GUI_SSL.Properties.Settings.Default.SaveParameters;
            this.saveParametersCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GUI_SSL.Properties.Settings.Default, "saveParameters", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.saveParametersCheckbox.Name = "saveParametersCheckbox";
            this.saveParametersCheckbox.UseVisualStyleBackColor = true;
            // 
            // openSSLLocationTextbox
            // 
            this.openSSLLocationTextbox.AllowDrop = true;
            this.openSSLLocationTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GUI_SSL.Properties.Settings.Default, "OpenSSLPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.openSSLLocationTextbox, "openSSLLocationTextbox");
            this.openSSLLocationTextbox.Name = "openSSLLocationTextbox";
            this.openSSLLocationTextbox.Text = global::GUI_SSL.Properties.Settings.Default.OpenSSLPath;
            this.openSSLLocationTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.File_Drag_Drop);
            this.openSSLLocationTextbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.File_Drag_Enter);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GUI_SSL.Properties.Settings.Default, "outputPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.textBoxOutput, "textBoxOutput");
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Text = global::GUI_SSL.Properties.Settings.Default.OutputPath;
            // 
            // certPathTextbox
            // 
            this.certPathTextbox.AllowDrop = true;
            this.certPathTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GUI_SSL.Properties.Settings.Default, "certPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.certPathTextbox, "certPathTextbox");
            this.certPathTextbox.Name = "certPathTextbox";
            this.certPathTextbox.Text = global::GUI_SSL.Properties.Settings.Default.CertPath;
            this.certPathTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.File_Drag_Drop);
            this.certPathTextbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.File_Drag_Enter);
            // 
            // removeBagCheckbox
            // 
            resources.ApplyResources(this.removeBagCheckbox, "removeBagCheckbox");
            this.removeBagCheckbox.Checked = global::GUI_SSL.Properties.Settings.Default.RemoveBagAttributes;
            this.removeBagCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GUI_SSL.Properties.Settings.Default, "RemoveBagAttributes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.removeBagCheckbox.Name = "removeBagCheckbox";
            this.removeBagCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PFXradioButton);
            this.groupBox1.Controls.Add(this.P7BradioButton);
            this.groupBox1.Controls.Add(this.DERradioButton);
            this.groupBox1.Controls.Add(this.PEMradioButton);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // PFXradioButton
            // 
            resources.ApplyResources(this.PFXradioButton, "PFXradioButton");
            this.PFXradioButton.Name = "PFXradioButton";
            this.PFXradioButton.TabStop = true;
            this.PFXradioButton.UseVisualStyleBackColor = true;
            // 
            // P7BradioButton
            // 
            resources.ApplyResources(this.P7BradioButton, "P7BradioButton");
            this.P7BradioButton.Name = "P7BradioButton";
            this.P7BradioButton.TabStop = true;
            this.P7BradioButton.UseVisualStyleBackColor = true;
            // 
            // DERradioButton
            // 
            resources.ApplyResources(this.DERradioButton, "DERradioButton");
            this.DERradioButton.Name = "DERradioButton";
            this.DERradioButton.TabStop = true;
            this.DERradioButton.UseVisualStyleBackColor = true;
            // 
            // PEMradioButton
            // 
            resources.ApplyResources(this.PEMradioButton, "PEMradioButton");
            this.PEMradioButton.Checked = true;
            this.PEMradioButton.Name = "PEMradioButton";
            this.PEMradioButton.TabStop = true;
            this.PEMradioButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDE);
            this.Controls.Add(this.buttonUS);
            this.Controls.Add(this.buttonPL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.removeBagCheckbox);
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
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.CheckBox removeBagCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PFXradioButton;
        private System.Windows.Forms.RadioButton P7BradioButton;
        private System.Windows.Forms.RadioButton DERradioButton;
        private System.Windows.Forms.RadioButton PEMradioButton;
        private System.Windows.Forms.Button buttonPL;
        private System.Windows.Forms.Button buttonUS;
        private System.Windows.Forms.Button buttonDE;
    }
}

