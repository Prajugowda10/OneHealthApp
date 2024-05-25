namespace OneHealth
{
    partial class BMI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BMILabel = new Label();
            BMILabel2 = new Label();
            BMILabel3 = new Label();
            BMIbutton1 = new Button();
            BMItextBox1 = new TextBox();
            BMItextBox2 = new TextBox();
            BMItextBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // BMILabel
            // 
            BMILabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BMILabel.AutoSize = true;
            BMILabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BMILabel.ForeColor = Color.Lavender;
            BMILabel.ImageAlign = ContentAlignment.BottomLeft;
            BMILabel.Location = new Point(191, 107);
            BMILabel.Name = "BMILabel";
            BMILabel.Size = new Size(257, 41);
            BMILabel.TabIndex = 0;
            BMILabel.Text = "BMI CALCULATOR";
            // 
            // BMILabel2
            // 
            BMILabel2.AutoSize = true;
            BMILabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BMILabel2.ForeColor = Color.Lavender;
            BMILabel2.Location = new Point(139, 177);
            BMILabel2.Name = "BMILabel2";
            BMILabel2.Size = new Size(141, 28);
            BMILabel2.TabIndex = 1;
            BMILabel2.Text = "Height(in Cms)";
            BMILabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BMILabel3
            // 
            BMILabel3.AutoSize = true;
            BMILabel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BMILabel3.ForeColor = Color.Lavender;
            BMILabel3.Location = new Point(139, 265);
            BMILabel3.Name = "BMILabel3";
            BMILabel3.Size = new Size(140, 28);
            BMILabel3.TabIndex = 2;
            BMILabel3.Text = "Weight(in Kgs)";
            // 
            // BMIbutton1
            // 
            BMIbutton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BMIbutton1.ForeColor = Color.Coral;
            BMIbutton1.Location = new Point(176, 365);
            BMIbutton1.Margin = new Padding(3, 4, 3, 4);
            BMIbutton1.Name = "BMIbutton1";
            BMIbutton1.Size = new Size(97, 44);
            BMIbutton1.TabIndex = 3;
            BMIbutton1.Text = "Calculate";
            BMIbutton1.UseVisualStyleBackColor = true;
            BMIbutton1.Click += BMIbutton1_Click;
            // 
            // BMItextBox1
            // 
            BMItextBox1.Location = new Point(313, 180);
            BMItextBox1.Margin = new Padding(3, 4, 3, 4);
            BMItextBox1.Name = "BMItextBox1";
            BMItextBox1.Size = new Size(217, 27);
            BMItextBox1.TabIndex = 4;
            // 
            // BMItextBox2
            // 
            BMItextBox2.Location = new Point(313, 268);
            BMItextBox2.Margin = new Padding(3, 4, 3, 4);
            BMItextBox2.Name = "BMItextBox2";
            BMItextBox2.Size = new Size(217, 27);
            BMItextBox2.TabIndex = 5;
            // 
            // BMItextBox3
            // 
            BMItextBox3.Location = new Point(313, 361);
            BMItextBox3.Margin = new Padding(3, 4, 3, 4);
            BMItextBox3.Multiline = true;
            BMItextBox3.Name = "BMItextBox3";
            BMItextBox3.Size = new Size(217, 106);
            BMItextBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(176, 428);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 8;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BMI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 25, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(658, 497);
            Controls.Add(button1);
            Controls.Add(BMItextBox3);
            Controls.Add(BMItextBox2);
            Controls.Add(BMItextBox1);
            Controls.Add(BMIbutton1);
            Controls.Add(BMILabel3);
            Controls.Add(BMILabel2);
            Controls.Add(BMILabel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BMI";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "BMI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BMILabel;
        private Label BMILabel2;
        private Label BMILabel3;
        private Button BMIbutton1;
        private TextBox BMItextBox1;
        private TextBox BMItextBox2;
        private TextBox BMItextBox3;
        private Button button1;
    }
}