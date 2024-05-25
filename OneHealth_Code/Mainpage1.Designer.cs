namespace OneHealth
{
    partial class Mainpage1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainpage1));
            MP1label1 = new Label();
            MP1linkLabel1 = new LinkLabel();
            MP1linkLabel2 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MP1label1
            // 
            MP1label1.AutoSize = true;
            MP1label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            MP1label1.ForeColor = Color.LavenderBlush;
            MP1label1.Location = new Point(89, 140);
            MP1label1.Name = "MP1label1";
            MP1label1.Size = new Size(735, 67);
            MP1label1.TabIndex = 0;
            MP1label1.Text = "Hello , Hope you are doing well!";
            MP1label1.Click += MP1label1_Click;
            // 
            // MP1linkLabel1
            // 
            MP1linkLabel1.AutoSize = true;
            MP1linkLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MP1linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            MP1linkLabel1.LinkColor = Color.MistyRose;
            MP1linkLabel1.Location = new Point(306, 250);
            MP1linkLabel1.Name = "MP1linkLabel1";
            MP1linkLabel1.Size = new Size(109, 41);
            MP1linkLabel1.TabIndex = 1;
            MP1linkLabel1.TabStop = true;
            MP1linkLabel1.Text = "Sign In";
            MP1linkLabel1.VisitedLinkColor = Color.Red;
            MP1linkLabel1.LinkClicked += MP1linkLabel1_LinkClicked;
            // 
            // MP1linkLabel2
            // 
            MP1linkLabel2.ActiveLinkColor = Color.WhiteSmoke;
            MP1linkLabel2.AutoSize = true;
            MP1linkLabel2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MP1linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            MP1linkLabel2.LinkColor = Color.WhiteSmoke;
            MP1linkLabel2.Location = new Point(454, 250);
            MP1linkLabel2.Name = "MP1linkLabel2";
            MP1linkLabel2.Size = new Size(125, 41);
            MP1linkLabel2.TabIndex = 2;
            MP1linkLabel2.TabStop = true;
            MP1linkLabel2.Text = "Register";
            MP1linkLabel2.VisitedLinkColor = Color.Red;
            MP1linkLabel2.LinkClicked += MP1linkLabel2_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(234, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(469, 95);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Mainpage1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(956, 365);
            Controls.Add(pictureBox1);
            Controls.Add(MP1linkLabel2);
            Controls.Add(MP1linkLabel1);
            Controls.Add(MP1label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mainpage1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ange";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MP1label1;
        private LinkLabel MP1linkLabel1;
        private LinkLabel MP1linkLabel2;
        private PictureBox pictureBox1;
    }
}