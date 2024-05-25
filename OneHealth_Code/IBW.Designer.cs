namespace OneHealth
{
    partial class IBW
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
            IBMlabel2 = new Label();
            IBMlabel3 = new Label();
            IBMbutton1 = new Button();
            IBMradioButton1 = new RadioButton();
            IBMradioButton2 = new RadioButton();
            IBMtextBox1 = new TextBox();
            IBMtextBox2 = new TextBox();
            IBMtextBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(256, 75);
            label1.Name = "label1";
            label1.Size = new Size(256, 41);
            label1.TabIndex = 0;
            label1.Text = "Ideal Body weight";
            // 
            // IBMlabel2
            // 
            IBMlabel2.AutoSize = true;
            IBMlabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IBMlabel2.ForeColor = Color.Lavender;
            IBMlabel2.Location = new Point(256, 167);
            IBMlabel2.Name = "IBMlabel2";
            IBMlabel2.Size = new Size(47, 28);
            IBMlabel2.TabIndex = 1;
            IBMlabel2.Text = "Age";
            // 
            // IBMlabel3
            // 
            IBMlabel3.AutoSize = true;
            IBMlabel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IBMlabel3.ForeColor = Color.Lavender;
            IBMlabel3.Location = new Point(196, 247);
            IBMlabel3.Name = "IBMlabel3";
            IBMlabel3.Size = new Size(143, 28);
            IBMlabel3.TabIndex = 2;
            IBMlabel3.Text = "Height(in mtrs)";
            // 
            // IBMbutton1
            // 
            IBMbutton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IBMbutton1.ForeColor = Color.Coral;
            IBMbutton1.Location = new Point(222, 382);
            IBMbutton1.Margin = new Padding(3, 4, 3, 4);
            IBMbutton1.Name = "IBMbutton1";
            IBMbutton1.Size = new Size(104, 49);
            IBMbutton1.TabIndex = 3;
            IBMbutton1.Text = "Calculate";
            IBMbutton1.UseVisualStyleBackColor = true;
            IBMbutton1.Click += IBMbutton1_Click;
            // 
            // IBMradioButton1
            // 
            IBMradioButton1.AutoSize = true;
            IBMradioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IBMradioButton1.ForeColor = Color.Lavender;
            IBMradioButton1.Location = new Point(362, 314);
            IBMradioButton1.Margin = new Padding(3, 4, 3, 4);
            IBMradioButton1.Name = "IBMradioButton1";
            IBMradioButton1.Size = new Size(76, 32);
            IBMradioButton1.TabIndex = 4;
            IBMradioButton1.TabStop = true;
            IBMradioButton1.Text = "Male";
            IBMradioButton1.UseVisualStyleBackColor = true;
            // 
            // IBMradioButton2
            // 
            IBMradioButton2.AutoSize = true;
            IBMradioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IBMradioButton2.ForeColor = Color.Lavender;
            IBMradioButton2.Location = new Point(444, 314);
            IBMradioButton2.Margin = new Padding(3, 4, 3, 4);
            IBMradioButton2.Name = "IBMradioButton2";
            IBMradioButton2.Size = new Size(95, 32);
            IBMradioButton2.TabIndex = 5;
            IBMradioButton2.TabStop = true;
            IBMradioButton2.Text = "Female";
            IBMradioButton2.UseVisualStyleBackColor = true;
            // 
            // IBMtextBox1
            // 
            IBMtextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IBMtextBox1.Location = new Point(362, 167);
            IBMtextBox1.Margin = new Padding(3, 4, 3, 4);
            IBMtextBox1.Name = "IBMtextBox1";
            IBMtextBox1.Size = new Size(169, 34);
            IBMtextBox1.TabIndex = 6;
            // 
            // IBMtextBox2
            // 
            IBMtextBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IBMtextBox2.Location = new Point(362, 241);
            IBMtextBox2.Margin = new Padding(3, 4, 3, 4);
            IBMtextBox2.Name = "IBMtextBox2";
            IBMtextBox2.Size = new Size(169, 34);
            IBMtextBox2.TabIndex = 7;
            // 
            // IBMtextBox3
            // 
            IBMtextBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IBMtextBox3.Location = new Point(362, 382);
            IBMtextBox3.Margin = new Padding(3, 4, 3, 4);
            IBMtextBox3.Multiline = true;
            IBMtextBox3.Name = "IBMtextBox3";
            IBMtextBox3.Size = new Size(169, 95);
            IBMtextBox3.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(222, 438);
            button1.Name = "button1";
            button1.Size = new Size(104, 39);
            button1.TabIndex = 10;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // IBW
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 25, 255);
            ClientSize = new Size(726, 509);
            Controls.Add(button1);
            Controls.Add(IBMtextBox3);
            Controls.Add(IBMtextBox2);
            Controls.Add(IBMtextBox1);
            Controls.Add(IBMradioButton2);
            Controls.Add(IBMradioButton1);
            Controls.Add(IBMbutton1);
            Controls.Add(IBMlabel3);
            Controls.Add(IBMlabel2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "IBW";
            Text = "Ideal Body weight";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label IBMlabel2;
        private Label IBMlabel3;
        private Button IBMbutton1;
        private RadioButton IBMradioButton1;
        private RadioButton IBMradioButton2;
        private TextBox IBMtextBox1;
        private TextBox IBMtextBox2;
        private TextBox IBMtextBox3;
        private Button button1;
    }
}