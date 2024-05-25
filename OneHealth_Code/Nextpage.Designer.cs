namespace OneHealth
{
    partial class Nextpage
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
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(92, 138);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(863, 42);
            label1.TabIndex = 0;
            label1.Text = "\"The wish for healing has always been half of health\"";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 15F, FontStyle.Underline, GraphicsUnit.Point);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.Coral;
            linkLabel1.Location = new Point(480, 209);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(97, 29);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "next  >>";
            linkLabel1.VisitedLinkColor = Color.Red;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Nextpage
            // 
            AutoScaleDimensions = new SizeF(23F, 44F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1029, 278);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Font = new Font("Stencil", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(9, 7, 9, 7);
            Name = "Nextpage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "OneHealth";
            Load += Nextpage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
    }
}