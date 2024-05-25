namespace OneHealth
{
    partial class WTH
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
            WTHlabel1 = new Label();
            WTHlabel2 = new Label();
            WTHlabel3 = new Label();
            WTHtextBox1 = new TextBox();
            WTHtextBox2 = new TextBox();
            WTHbutton1 = new Button();
            WTHtextBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // WTHlabel1
            // 
            WTHlabel1.AutoSize = true;
            WTHlabel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            WTHlabel1.Location = new Point(171, 85);
            WTHlabel1.Name = "WTHlabel1";
            WTHlabel1.Size = new Size(248, 41);
            WTHlabel1.TabIndex = 0;
            WTHlabel1.Text = "Waist to Hip ratio";
            // 
            // WTHlabel2
            // 
            WTHlabel2.AutoSize = true;
            WTHlabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WTHlabel2.Location = new Point(112, 168);
            WTHlabel2.Name = "WTHlabel2";
            WTHlabel2.Size = new Size(188, 28);
            WTHlabel2.TabIndex = 1;
            WTHlabel2.Text = "Waist (circumfrence)";
            // 
            // WTHlabel3
            // 
            WTHlabel3.AutoSize = true;
            WTHlabel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WTHlabel3.Location = new Point(112, 238);
            WTHlabel3.Name = "WTHlabel3";
            WTHlabel3.Size = new Size(169, 28);
            WTHlabel3.TabIndex = 2;
            WTHlabel3.Text = "Hip(Circumfernce)";
            // 
            // WTHtextBox1
            // 
            WTHtextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WTHtextBox1.Location = new Point(363, 165);
            WTHtextBox1.Margin = new Padding(3, 4, 3, 4);
            WTHtextBox1.Name = "WTHtextBox1";
            WTHtextBox1.Size = new Size(163, 34);
            WTHtextBox1.TabIndex = 3;
            // 
            // WTHtextBox2
            // 
            WTHtextBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WTHtextBox2.Location = new Point(363, 238);
            WTHtextBox2.Margin = new Padding(3, 4, 3, 4);
            WTHtextBox2.Name = "WTHtextBox2";
            WTHtextBox2.Size = new Size(163, 34);
            WTHtextBox2.TabIndex = 4;
            // 
            // WTHbutton1
            // 
            WTHbutton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WTHbutton1.ForeColor = Color.Coral;
            WTHbutton1.Location = new Point(143, 322);
            WTHbutton1.Margin = new Padding(3, 4, 3, 4);
            WTHbutton1.Name = "WTHbutton1";
            WTHbutton1.Size = new Size(114, 49);
            WTHbutton1.TabIndex = 5;
            WTHbutton1.Text = "Calculate";
            WTHbutton1.UseVisualStyleBackColor = true;
            WTHbutton1.Click += WTHbutton1_Click;
            // 
            // WTHtextBox3
            // 
            WTHtextBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WTHtextBox3.Location = new Point(363, 322);
            WTHtextBox3.Margin = new Padding(3, 4, 3, 4);
            WTHtextBox3.Multiline = true;
            WTHtextBox3.Name = "WTHtextBox3";
            WTHtextBox3.Size = new Size(163, 100);
            WTHtextBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(143, 383);
            button1.Name = "button1";
            button1.Size = new Size(114, 39);
            button1.TabIndex = 9;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // WTH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 25, 255);
            ClientSize = new Size(601, 458);
            Controls.Add(button1);
            Controls.Add(WTHtextBox3);
            Controls.Add(WTHbutton1);
            Controls.Add(WTHtextBox2);
            Controls.Add(WTHtextBox1);
            Controls.Add(WTHlabel3);
            Controls.Add(WTHlabel2);
            Controls.Add(WTHlabel1);
            ForeColor = Color.Lavender;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "WTH";
            Text = "Waist To Hip Ratio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WTHlabel1;
        private Label WTHlabel2;
        private Label WTHlabel3;
        private TextBox WTHtextBox1;
        private TextBox WTHtextBox2;
        private Button WTHbutton1;
        private TextBox WTHtextBox3;
        private Button button1;
    }
}