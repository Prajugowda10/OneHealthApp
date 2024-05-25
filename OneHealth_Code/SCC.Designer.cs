namespace OneHealth
{
    partial class SCC
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
            SCClabel1 = new Label();
            SCClabel2 = new Label();
            SCCbutton1 = new Button();
            SCCtextBox1 = new TextBox();
            SCCtextBox3 = new TextBox();
            SCClabel3 = new Label();
            SCCtextBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // SCClabel1
            // 
            SCClabel1.AutoSize = true;
            SCClabel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SCClabel1.ForeColor = Color.Lavender;
            SCClabel1.Location = new Point(181, 87);
            SCClabel1.Name = "SCClabel1";
            SCClabel1.Size = new Size(343, 41);
            SCClabel1.TabIndex = 0;
            SCClabel1.Text = "Smoking Cost Calculator";
            // 
            // SCClabel2
            // 
            SCClabel2.AutoSize = true;
            SCClabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SCClabel2.ForeColor = Color.Lavender;
            SCClabel2.Location = new Point(64, 180);
            SCClabel2.Name = "SCClabel2";
            SCClabel2.Size = new Size(391, 28);
            SCClabel2.TabIndex = 1;
            SCClabel2.Text = "Since When did  you start Smoking(In days)";
            // 
            // SCCbutton1
            // 
            SCCbutton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SCCbutton1.ForeColor = Color.Coral;
            SCCbutton1.Location = new Point(206, 383);
            SCCbutton1.Margin = new Padding(3, 4, 3, 4);
            SCCbutton1.Name = "SCCbutton1";
            SCCbutton1.Size = new Size(136, 53);
            SCCbutton1.TabIndex = 5;
            SCCbutton1.Text = "Calculate";
            SCCbutton1.UseVisualStyleBackColor = true;
            SCCbutton1.Click += SCCbutton1_Click_1;
            // 
            // SCCtextBox1
            // 
            SCCtextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SCCtextBox1.Location = new Point(483, 183);
            SCCtextBox1.Margin = new Padding(3, 4, 3, 4);
            SCCtextBox1.Name = "SCCtextBox1";
            SCCtextBox1.Size = new Size(209, 34);
            SCCtextBox1.TabIndex = 6;
            // 
            // SCCtextBox3
            // 
            SCCtextBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SCCtextBox3.Location = new Point(483, 383);
            SCCtextBox3.Margin = new Padding(3, 4, 3, 4);
            SCCtextBox3.Multiline = true;
            SCCtextBox3.Name = "SCCtextBox3";
            SCCtextBox3.Size = new Size(209, 104);
            SCCtextBox3.TabIndex = 10;
            // 
            // SCClabel3
            // 
            SCClabel3.AutoSize = true;
            SCClabel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SCClabel3.ForeColor = Color.Lavender;
            SCClabel3.Location = new Point(64, 267);
            SCClabel3.Name = "SCClabel3";
            SCClabel3.Size = new Size(390, 28);
            SCClabel3.TabIndex = 11;
            SCClabel3.Text = "How many Cigarette do you smoke per day";
            // 
            // SCCtextBox2
            // 
            SCCtextBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SCCtextBox2.Location = new Point(483, 264);
            SCCtextBox2.Margin = new Padding(3, 4, 3, 4);
            SCCtextBox2.Name = "SCCtextBox2";
            SCCtextBox2.Size = new Size(209, 34);
            SCCtextBox2.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(206, 448);
            button1.Name = "button1";
            button1.Size = new Size(136, 39);
            button1.TabIndex = 14;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SCC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 25, 255);
            ClientSize = new Size(767, 533);
            Controls.Add(button1);
            Controls.Add(SCCtextBox2);
            Controls.Add(SCClabel3);
            Controls.Add(SCCtextBox3);
            Controls.Add(SCCtextBox1);
            Controls.Add(SCCbutton1);
            Controls.Add(SCClabel2);
            Controls.Add(SCClabel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SCC";
            Text = "Smoking Cost Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SCClabel1;
        private Label SCClabel2;
        private Button SCCbutton1;
        private TextBox SCCtextBox1;
        private TextBox SCCtextBox3;
        private Label SCClabel3;
        private TextBox SCCtextBox2;
        private Button button1;
    }
}