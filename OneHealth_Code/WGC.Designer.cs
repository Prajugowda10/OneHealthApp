namespace OneHealth
{
    partial class WGC
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
            WGClabel1 = new Label();
            WGClabel2 = new Label();
            WGClabel3 = new Label();
            WGClabel4 = new Label();
            WGCtextBox1 = new TextBox();
            WGCtextBox2 = new TextBox();
            WGCtextBox3 = new TextBox();
            WGCbutton1 = new Button();
            WGCtextBox4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // WGClabel1
            // 
            WGClabel1.AutoSize = true;
            WGClabel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            WGClabel1.Location = new Point(224, 82);
            WGClabel1.Name = "WGClabel1";
            WGClabel1.Size = new Size(321, 41);
            WGClabel1.TabIndex = 0;
            WGClabel1.Text = "Weight Gain Calculator";
            // 
            // WGClabel2
            // 
            WGClabel2.AutoSize = true;
            WGClabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WGClabel2.Location = new Point(169, 158);
            WGClabel2.Name = "WGClabel2";
            WGClabel2.Size = new Size(179, 28);
            WGClabel2.TabIndex = 1;
            WGClabel2.Text = "Current Weight(kg)";
            // 
            // WGClabel3
            // 
            WGClabel3.AutoSize = true;
            WGClabel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WGClabel3.Location = new Point(169, 228);
            WGClabel3.Name = "WGClabel3";
            WGClabel3.Size = new Size(168, 28);
            WGClabel3.TabIndex = 2;
            WGClabel3.Text = "Target Weight(kg)";
            // 
            // WGClabel4
            // 
            WGClabel4.AutoSize = true;
            WGClabel4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WGClabel4.Location = new Point(123, 306);
            WGClabel4.Name = "WGClabel4";
            WGClabel4.Size = new Size(547, 28);
            WGClabel4.TabIndex = 3;
            WGClabel4.Text = "How many days are you dedicating per week for weight gain?";
            // 
            // WGCtextBox1
            // 
            WGCtextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WGCtextBox1.Location = new Point(384, 158);
            WGCtextBox1.Margin = new Padding(3, 4, 3, 4);
            WGCtextBox1.Name = "WGCtextBox1";
            WGCtextBox1.Size = new Size(217, 34);
            WGCtextBox1.TabIndex = 4;
            WGCtextBox1.TextChanged += WGCtextBox1_TextChanged;
            // 
            // WGCtextBox2
            // 
            WGCtextBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WGCtextBox2.Location = new Point(384, 228);
            WGCtextBox2.Margin = new Padding(3, 4, 3, 4);
            WGCtextBox2.Name = "WGCtextBox2";
            WGCtextBox2.Size = new Size(217, 34);
            WGCtextBox2.TabIndex = 5;
            // 
            // WGCtextBox3
            // 
            WGCtextBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WGCtextBox3.Location = new Point(384, 361);
            WGCtextBox3.Margin = new Padding(3, 4, 3, 4);
            WGCtextBox3.Name = "WGCtextBox3";
            WGCtextBox3.Size = new Size(217, 34);
            WGCtextBox3.TabIndex = 6;
            // 
            // WGCbutton1
            // 
            WGCbutton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WGCbutton1.ForeColor = Color.Coral;
            WGCbutton1.Location = new Point(192, 439);
            WGCbutton1.Margin = new Padding(3, 4, 3, 4);
            WGCbutton1.Name = "WGCbutton1";
            WGCbutton1.Size = new Size(107, 47);
            WGCbutton1.TabIndex = 7;
            WGCbutton1.Text = "Calculate";
            WGCbutton1.UseVisualStyleBackColor = true;
            WGCbutton1.Click += WGCbutton1_Click;
            // 
            // WGCtextBox4
            // 
            WGCtextBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WGCtextBox4.Location = new Point(384, 439);
            WGCtextBox4.Margin = new Padding(3, 4, 3, 4);
            WGCtextBox4.Multiline = true;
            WGCtextBox4.Name = "WGCtextBox4";
            WGCtextBox4.Size = new Size(217, 101);
            WGCtextBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(192, 501);
            button1.Name = "button1";
            button1.Size = new Size(107, 39);
            button1.TabIndex = 10;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // WGC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 25, 255);
            ClientSize = new Size(763, 577);
            Controls.Add(button1);
            Controls.Add(WGCtextBox4);
            Controls.Add(WGCbutton1);
            Controls.Add(WGCtextBox3);
            Controls.Add(WGCtextBox2);
            Controls.Add(WGCtextBox1);
            Controls.Add(WGClabel4);
            Controls.Add(WGClabel3);
            Controls.Add(WGClabel2);
            Controls.Add(WGClabel1);
            ForeColor = Color.Lavender;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "WGC";
            Text = "Weight Gain Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WGClabel1;
        private Label WGClabel2;
        private Label WGClabel3;
        private Label WGClabel4;
        private TextBox WGCtextBox1;
        private TextBox WGCtextBox2;
        private TextBox WGCtextBox3;
        private Button WGCbutton1;
        private TextBox WGCtextBox4;
        private Button button1;
    }
}