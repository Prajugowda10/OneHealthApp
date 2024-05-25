namespace OneHealth
{
    partial class WI
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
            WIlabel2 = new Label();
            WItextBox1 = new TextBox();
            WIlabel3 = new Label();
            WIlabel4 = new Label();
            WIcomboBox2 = new ComboBox();
            WIbutton1 = new Button();
            WItextBox4 = new TextBox();
            WIcomboBox1 = new ComboBox();
            WIlabel5 = new Label();
            WIcheckBox1 = new CheckBox();
            WIcheckBox2 = new CheckBox();
            WIcheckBox3 = new CheckBox();
            WIcheckBox4 = new CheckBox();
            WIcheckBox5 = new CheckBox();
            WIcheckBox6 = new CheckBox();
            WIcheckBox7 = new CheckBox();
            WIcheckBox8 = new CheckBox();
            WIcheckBox9 = new CheckBox();
            WIcheckBox10 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(309, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(325, 41);
            label1.TabIndex = 0;
            label1.Text = "Water Intake Calculator";
            // 
            // WIlabel2
            // 
            WIlabel2.AutoSize = true;
            WIlabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WIlabel2.Location = new Point(67, 143);
            WIlabel2.Margin = new Padding(4, 0, 4, 0);
            WIlabel2.Name = "WIlabel2";
            WIlabel2.Size = new Size(75, 28);
            WIlabel2.TabIndex = 1;
            WIlabel2.Text = "Weight";
            // 
            // WItextBox1
            // 
            WItextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WItextBox1.Location = new Point(181, 140);
            WItextBox1.Margin = new Padding(4);
            WItextBox1.Name = "WItextBox1";
            WItextBox1.Size = new Size(277, 34);
            WItextBox1.TabIndex = 2;
            // 
            // WIlabel3
            // 
            WIlabel3.AutoSize = true;
            WIlabel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WIlabel3.Location = new Point(528, 143);
            WIlabel3.Margin = new Padding(4, 0, 4, 0);
            WIlabel3.Name = "WIlabel3";
            WIlabel3.Size = new Size(78, 28);
            WIlabel3.TabIndex = 4;
            WIlabel3.Text = "Activity";
            // 
            // WIlabel4
            // 
            WIlabel4.AutoSize = true;
            WIlabel4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WIlabel4.Location = new Point(528, 219);
            WIlabel4.Margin = new Padding(4, 0, 4, 0);
            WIlabel4.Name = "WIlabel4";
            WIlabel4.Size = new Size(78, 28);
            WIlabel4.TabIndex = 5;
            WIlabel4.Text = "Climate";
            // 
            // WIcomboBox2
            // 
            WIcomboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WIcomboBox2.ForeColor = Color.Coral;
            WIcomboBox2.FormattingEnabled = true;
            WIcomboBox2.Items.AddRange(new object[] { "Tropical", "Temperate", "Cold" });
            WIcomboBox2.Location = new Point(685, 210);
            WIcomboBox2.Margin = new Padding(4);
            WIcomboBox2.Name = "WIcomboBox2";
            WIcomboBox2.Size = new Size(194, 36);
            WIcomboBox2.TabIndex = 6;
            WIcomboBox2.Text = "Select any one...";
            // 
            // WIbutton1
            // 
            WIbutton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WIbutton1.ForeColor = Color.Coral;
            WIbutton1.Location = new Point(528, 377);
            WIbutton1.Margin = new Padding(4);
            WIbutton1.Name = "WIbutton1";
            WIbutton1.Size = new Size(121, 46);
            WIbutton1.TabIndex = 7;
            WIbutton1.Text = "Calculate";
            WIbutton1.UseVisualStyleBackColor = true;
            WIbutton1.Click += WIbutton1_Click;
            // 
            // WItextBox4
            // 
            WItextBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WItextBox4.Location = new Point(685, 330);
            WItextBox4.Margin = new Padding(4);
            WItextBox4.Multiline = true;
            WItextBox4.Name = "WItextBox4";
            WItextBox4.Size = new Size(194, 117);
            WItextBox4.TabIndex = 8;
            // 
            // WIcomboBox1
            // 
            WIcomboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WIcomboBox1.ForeColor = Color.Coral;
            WIcomboBox1.FormattingEnabled = true;
            WIcomboBox1.Items.AddRange(new object[] { "Sedentary", "Moderately Active", "Light Activity", "Highly Active", "Extremely Active" });
            WIcomboBox1.Location = new Point(685, 140);
            WIcomboBox1.Margin = new Padding(4);
            WIcomboBox1.Name = "WIcomboBox1";
            WIcomboBox1.Size = new Size(194, 36);
            WIcomboBox1.TabIndex = 3;
            WIcomboBox1.Text = "Select any one...";
            // 
            // WIlabel5
            // 
            WIlabel5.AutoSize = true;
            WIlabel5.Location = new Point(56, 218);
            WIlabel5.Name = "WIlabel5";
            WIlabel5.Size = new Size(108, 28);
            WIlabel5.TabIndex = 9;
            WIlabel5.Text = "Age Group";
            // 
            // WIcheckBox1
            // 
            WIcheckBox1.AutoSize = true;
            WIcheckBox1.Location = new Point(171, 218);
            WIcheckBox1.Name = "WIcheckBox1";
            WIcheckBox1.Size = new Size(145, 32);
            WIcheckBox1.TabIndex = 10;
            WIcheckBox1.Text = "0 - 6 months";
            WIcheckBox1.UseVisualStyleBackColor = true;
            // 
            // WIcheckBox2
            // 
            WIcheckBox2.AutoSize = true;
            WIcheckBox2.Location = new Point(331, 217);
            WIcheckBox2.Name = "WIcheckBox2";
            WIcheckBox2.Size = new Size(156, 32);
            WIcheckBox2.TabIndex = 11;
            WIcheckBox2.Text = "7 - 12 months";
            WIcheckBox2.UseVisualStyleBackColor = true;
            // 
            // WIcheckBox3
            // 
            WIcheckBox3.AutoSize = true;
            WIcheckBox3.Location = new Point(171, 272);
            WIcheckBox3.Name = "WIcheckBox3";
            WIcheckBox3.Size = new Size(124, 32);
            WIcheckBox3.TabIndex = 12;
            WIcheckBox3.Text = "1 - 3 years";
            WIcheckBox3.UseVisualStyleBackColor = true;
            // 
            // WIcheckBox4
            // 
            WIcheckBox4.AutoSize = true;
            WIcheckBox4.Location = new Point(331, 272);
            WIcheckBox4.Name = "WIcheckBox4";
            WIcheckBox4.Size = new Size(124, 32);
            WIcheckBox4.TabIndex = 13;
            WIcheckBox4.Text = "4 - 8 years";
            WIcheckBox4.UseVisualStyleBackColor = true;
            // 
            // WIcheckBox5
            // 
            WIcheckBox5.AutoSize = true;
            WIcheckBox5.Location = new Point(171, 330);
            WIcheckBox5.Name = "WIcheckBox5";
            WIcheckBox5.Size = new Size(189, 32);
            WIcheckBox5.TabIndex = 14;
            WIcheckBox5.Text = "9 - 13 years(boys)";
            WIcheckBox5.UseVisualStyleBackColor = true;
            // 
            // WIcheckBox6
            // 
            WIcheckBox6.AutoSize = true;
            WIcheckBox6.Location = new Point(331, 330);
            WIcheckBox6.Name = "WIcheckBox6";
            WIcheckBox6.Size = new Size(184, 32);
            WIcheckBox6.TabIndex = 15;
            WIcheckBox6.Text = "9 - 13 years(girls)";
            WIcheckBox6.UseVisualStyleBackColor = true;
            // 
            // WIcheckBox7
            // 
            WIcheckBox7.AutoSize = true;
            WIcheckBox7.Location = new Point(171, 385);
            WIcheckBox7.Name = "WIcheckBox7";
            WIcheckBox7.Size = new Size(200, 32);
            WIcheckBox7.TabIndex = 16;
            WIcheckBox7.Text = "14 - 18 years(boys)";
            WIcheckBox7.UseVisualStyleBackColor = true;
            // 
            // WIcheckBox8
            // 
            WIcheckBox8.AutoSize = true;
            WIcheckBox8.Location = new Point(331, 385);
            WIcheckBox8.Name = "WIcheckBox8";
            WIcheckBox8.Size = new Size(195, 32);
            WIcheckBox8.TabIndex = 17;
            WIcheckBox8.Text = "14 - 18 years(girls)";
            WIcheckBox8.UseVisualStyleBackColor = true;
            // 
            // WIcheckBox9
            // 
            WIcheckBox9.AutoSize = true;
            WIcheckBox9.Location = new Point(171, 442);
            WIcheckBox9.Name = "WIcheckBox9";
            WIcheckBox9.Size = new Size(141, 32);
            WIcheckBox9.TabIndex = 18;
            WIcheckBox9.Text = "Adults(Men)";
            WIcheckBox9.UseVisualStyleBackColor = true;
            // 
            // WIcheckBox10
            // 
            WIcheckBox10.AutoSize = true;
            WIcheckBox10.Location = new Point(331, 442);
            WIcheckBox10.Name = "WIcheckBox10";
            WIcheckBox10.Size = new Size(170, 32);
            WIcheckBox10.TabIndex = 19;
            WIcheckBox10.Text = "Adults(Women)";
            WIcheckBox10.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(528, 326);
            button1.Name = "button1";
            button1.Size = new Size(121, 39);
            button1.TabIndex = 21;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // WI
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 25, 255);
            ClientSize = new Size(934, 497);
            Controls.Add(button1);
            Controls.Add(WIcheckBox10);
            Controls.Add(WIcheckBox9);
            Controls.Add(WIcheckBox8);
            Controls.Add(WIcheckBox7);
            Controls.Add(WIcheckBox6);
            Controls.Add(WIcheckBox5);
            Controls.Add(WIcheckBox4);
            Controls.Add(WIcheckBox3);
            Controls.Add(WIcheckBox2);
            Controls.Add(WIcheckBox1);
            Controls.Add(WIlabel5);
            Controls.Add(WItextBox4);
            Controls.Add(WIbutton1);
            Controls.Add(WIcomboBox2);
            Controls.Add(WIlabel4);
            Controls.Add(WIlabel3);
            Controls.Add(WIcomboBox1);
            Controls.Add(WItextBox1);
            Controls.Add(WIlabel2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Lavender;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "WI";
            Text = "Water Intake Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label WIlabel2;
        private TextBox WItextBox1;
        private Label WIlabel3;
        private Label WIlabel4;
        private ComboBox WIcomboBox2;
        private Button WIbutton1;
        private TextBox WItextBox4;
        private ComboBox WIcomboBox1;
        private Label WIlabel5;
        private CheckBox WIcheckBox1;
        private CheckBox WIcheckBox2;
        private CheckBox WIcheckBox3;
        private CheckBox WIcheckBox4;
        private CheckBox WIcheckBox5;
        private CheckBox WIcheckBox6;
        private CheckBox WIcheckBox7;
        private CheckBox WIcheckBox8;
        private CheckBox WIcheckBox9;
        private CheckBox WIcheckBox10;
        private Button button1;
    }
}