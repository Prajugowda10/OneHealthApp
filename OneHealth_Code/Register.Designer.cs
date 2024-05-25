namespace OneHealth
{
    partial class Register
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
            MP2label1 = new Label();
            MP2label2 = new Label();
            MP2label3 = new Label();
            MP2button1 = new Button();
            MP2textBox1 = new TextBox();
            MP2textBox2 = new TextBox();
            MP2label4 = new Label();
            MP2textBox3 = new TextBox();
            MP2button2 = new Button();
            MP2label5 = new Label();
            MP2linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // MP2label1
            // 
            MP2label1.AutoSize = true;
            MP2label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MP2label1.Location = new Point(326, 69);
            MP2label1.Name = "MP2label1";
            MP2label1.Size = new Size(125, 41);
            MP2label1.TabIndex = 0;
            MP2label1.Text = "Register";
            // 
            // MP2label2
            // 
            MP2label2.AutoSize = true;
            MP2label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MP2label2.Location = new Point(238, 156);
            MP2label2.Name = "MP2label2";
            MP2label2.Size = new Size(99, 28);
            MP2label2.TabIndex = 1;
            MP2label2.Text = "Username";
            // 
            // MP2label3
            // 
            MP2label3.AutoSize = true;
            MP2label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MP2label3.Location = new Point(244, 226);
            MP2label3.Name = "MP2label3";
            MP2label3.Size = new Size(93, 28);
            MP2label3.TabIndex = 2;
            MP2label3.Text = "Password";
            // 
            // MP2button1
            // 
            MP2button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MP2button1.ForeColor = Color.Coral;
            MP2button1.Location = new Point(325, 391);
            MP2button1.Name = "MP2button1";
            MP2button1.Size = new Size(126, 39);
            MP2button1.TabIndex = 3;
            MP2button1.Text = "Register";
            MP2button1.UseVisualStyleBackColor = true;
            MP2button1.Click += MP2button1_Click;
            // 
            // MP2textBox1
            // 
            MP2textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MP2textBox1.Location = new Point(396, 160);
            MP2textBox1.Name = "MP2textBox1";
            MP2textBox1.Size = new Size(158, 34);
            MP2textBox1.TabIndex = 4;
            // 
            // MP2textBox2
            // 
            MP2textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MP2textBox2.Location = new Point(396, 230);
            MP2textBox2.Name = "MP2textBox2";
            MP2textBox2.Size = new Size(158, 34);
            MP2textBox2.TabIndex = 5;
            // 
            // MP2label4
            // 
            MP2label4.AutoSize = true;
            MP2label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MP2label4.Location = new Point(207, 288);
            MP2label4.Name = "MP2label4";
            MP2label4.Size = new Size(168, 28);
            MP2label4.TabIndex = 7;
            MP2label4.Text = "Confirm Password";
            // 
            // MP2textBox3
            // 
            MP2textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MP2textBox3.Location = new Point(396, 292);
            MP2textBox3.Name = "MP2textBox3";
            MP2textBox3.Size = new Size(158, 34);
            MP2textBox3.TabIndex = 8;
            // 
            // MP2button2
            // 
            MP2button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MP2button2.ForeColor = Color.Coral;
            MP2button2.Location = new Point(476, 391);
            MP2button2.Name = "MP2button2";
            MP2button2.Size = new Size(83, 39);
            MP2button2.TabIndex = 9;
            MP2button2.Text = "Clear";
            MP2button2.UseVisualStyleBackColor = true;
            // 
            // MP2label5
            // 
            MP2label5.AutoSize = true;
            MP2label5.ForeColor = Color.Black;
            MP2label5.Location = new Point(366, 454);
            MP2label5.Name = "MP2label5";
            MP2label5.Size = new Size(223, 20);
            MP2label5.TabIndex = 10;
            MP2label5.Text = "Already Have an account Sign In";
            // 
            // MP2linkLabel1
            // 
            MP2linkLabel1.AutoSize = true;
            MP2linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MP2linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            MP2linkLabel1.Location = new Point(396, 474);
            MP2linkLabel1.Name = "MP2linkLabel1";
            MP2linkLabel1.Size = new Size(141, 28);
            MP2linkLabel1.TabIndex = 11;
            MP2linkLabel1.TabStop = true;
            MP2linkLabel1.Text = "Back to Sign In";
            MP2linkLabel1.LinkClicked += MP2linkLabel1_LinkClicked;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(842, 545);
            Controls.Add(MP2linkLabel1);
            Controls.Add(MP2label5);
            Controls.Add(MP2button2);
            Controls.Add(MP2textBox3);
            Controls.Add(MP2label4);
            Controls.Add(MP2textBox2);
            Controls.Add(MP2textBox1);
            Controls.Add(MP2button1);
            Controls.Add(MP2label3);
            Controls.Add(MP2label2);
            Controls.Add(MP2label1);
            ForeColor = Color.LavenderBlush;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MP2label1;
        private Label MP2label2;
        private Label MP2label3;
        private Button MP2button1;
        private TextBox MP2textBox1;
        private TextBox MP2textBox2;
        private Label MP2label4;
        private TextBox MP2textBox3;
        private Button MP2button2;
        private Label MP2label5;
        private LinkLabel MP2linkLabel1;
    }
}