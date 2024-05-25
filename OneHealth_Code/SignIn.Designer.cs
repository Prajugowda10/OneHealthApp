namespace OneHealth
{
    partial class SignIn
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
            MP3linkLabel1 = new LinkLabel();
            MP3label5 = new Label();
            MP3button2 = new Button();
            MP3textBox2 = new TextBox();
            MP3textBox1 = new TextBox();
            MP3button1 = new Button();
            MP3label3 = new Label();
            MP3label2 = new Label();
            MP3label1 = new Label();
            SuspendLayout();
            // 
            // MP3linkLabel1
            // 
            MP3linkLabel1.AutoSize = true;
            MP3linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MP3linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            MP3linkLabel1.LinkColor = Color.LavenderBlush;
            MP3linkLabel1.Location = new Point(379, 432);
            MP3linkLabel1.Name = "MP3linkLabel1";
            MP3linkLabel1.Size = new Size(82, 28);
            MP3linkLabel1.TabIndex = 23;
            MP3linkLabel1.TabStop = true;
            MP3linkLabel1.Text = "Register";
            MP3linkLabel1.LinkClicked += MP3linkLabel1_LinkClicked;
            // 
            // MP3label5
            // 
            MP3label5.AutoSize = true;
            MP3label5.Location = new Point(321, 412);
            MP3label5.Name = "MP3label5";
            MP3label5.Size = new Size(216, 20);
            MP3label5.TabIndex = 22;
            MP3label5.Text = "Dont Have an Account Register";
            // 
            // MP3button2
            // 
            MP3button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MP3button2.ForeColor = Color.Coral;
            MP3button2.Location = new Point(454, 304);
            MP3button2.Name = "MP3button2";
            MP3button2.Size = new Size(83, 39);
            MP3button2.TabIndex = 21;
            MP3button2.Text = "Clear";
            MP3button2.UseVisualStyleBackColor = true;
            MP3button2.Click += MP3button2_Click;
            // 
            // MP3textBox2
            // 
            MP3textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MP3textBox2.Location = new Point(379, 213);
            MP3textBox2.Name = "MP3textBox2";
            MP3textBox2.Size = new Size(158, 34);
            MP3textBox2.TabIndex = 17;
            // 
            // MP3textBox1
            // 
            MP3textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MP3textBox1.Location = new Point(379, 131);
            MP3textBox1.Name = "MP3textBox1";
            MP3textBox1.Size = new Size(158, 34);
            MP3textBox1.TabIndex = 16;
            // 
            // MP3button1
            // 
            MP3button1.DialogResult = DialogResult.OK;
            MP3button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MP3button1.ForeColor = Color.Coral;
            MP3button1.Location = new Point(321, 304);
            MP3button1.Name = "MP3button1";
            MP3button1.Size = new Size(106, 39);
            MP3button1.TabIndex = 15;
            MP3button1.Text = "Sign In";
            MP3button1.UseVisualStyleBackColor = true;
            MP3button1.Click += MP3button1_Click;
            // 
            // MP3label3
            // 
            MP3label3.AutoSize = true;
            MP3label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MP3label3.ForeColor = Color.LavenderBlush;
            MP3label3.Location = new Point(242, 216);
            MP3label3.Name = "MP3label3";
            MP3label3.Size = new Size(93, 28);
            MP3label3.TabIndex = 14;
            MP3label3.Text = "Password";
            // 
            // MP3label2
            // 
            MP3label2.AutoSize = true;
            MP3label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MP3label2.ForeColor = Color.LavenderBlush;
            MP3label2.Location = new Point(236, 134);
            MP3label2.Name = "MP3label2";
            MP3label2.Size = new Size(99, 28);
            MP3label2.TabIndex = 13;
            MP3label2.Text = "Username";
            // 
            // MP3label1
            // 
            MP3label1.AutoSize = true;
            MP3label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MP3label1.ForeColor = Color.LavenderBlush;
            MP3label1.Location = new Point(348, 55);
            MP3label1.Name = "MP3label1";
            MP3label1.Size = new Size(109, 41);
            MP3label1.TabIndex = 12;
            MP3label1.Text = "Sign In";
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(785, 478);
            Controls.Add(MP3linkLabel1);
            Controls.Add(MP3label5);
            Controls.Add(MP3button2);
            Controls.Add(MP3textBox2);
            Controls.Add(MP3textBox1);
            Controls.Add(MP3button1);
            Controls.Add(MP3label3);
            Controls.Add(MP3label2);
            Controls.Add(MP3label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OneHealth";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel MP3linkLabel1;
        private Label MP3label5;
        private Button MP3button2;
        private TextBox MP3textBox2;
        private TextBox MP3textBox1;
        private Button MP3button1;
        private Label MP3label3;
        private Label MP3label2;
        private Label MP3label1;
    }
}