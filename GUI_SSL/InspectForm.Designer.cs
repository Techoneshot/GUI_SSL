namespace GUI_SSL
{
    partial class InspectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.certRichTextBox = new System.Windows.Forms.RichTextBox();
            this.rootRichTextBox = new System.Windows.Forms.RichTextBox();
            this.keyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(333, 484);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // certRichTextBox
            // 
            this.certRichTextBox.Location = new System.Drawing.Point(339, 0);
            this.certRichTextBox.Name = "certRichTextBox";
            this.certRichTextBox.Size = new System.Drawing.Size(454, 156);
            this.certRichTextBox.TabIndex = 1;
            this.certRichTextBox.Text = "";
            // 
            // rootRichTextBox
            // 
            this.rootRichTextBox.Location = new System.Drawing.Point(339, 162);
            this.rootRichTextBox.Name = "rootRichTextBox";
            this.rootRichTextBox.Size = new System.Drawing.Size(454, 156);
            this.rootRichTextBox.TabIndex = 2;
            this.rootRichTextBox.Text = "";
            // 
            // keyRichTextBox
            // 
            this.keyRichTextBox.Location = new System.Drawing.Point(339, 324);
            this.keyRichTextBox.Name = "keyRichTextBox";
            this.keyRichTextBox.Size = new System.Drawing.Size(454, 156);
            this.keyRichTextBox.TabIndex = 3;
            this.keyRichTextBox.Text = "";
            // 
            // InspectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.keyRichTextBox);
            this.Controls.Add(this.rootRichTextBox);
            this.Controls.Add(this.certRichTextBox);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InspectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Shown += new System.EventHandler(this.InspectForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox certRichTextBox;
        private System.Windows.Forms.RichTextBox rootRichTextBox;
        private System.Windows.Forms.RichTextBox keyRichTextBox;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}