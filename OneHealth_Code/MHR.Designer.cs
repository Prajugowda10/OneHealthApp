namespace OneHealth
{
    partial class MHR
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
            MHRlabel1 = new Label();
            MHRlabel2 = new Label();
            MHRtextBox1 = new TextBox();
            MHRbutton1 = new Button();
            MHRtextBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // MHRlabel1
            // 
            MHRlabel1.AutoSize = true;
            MHRlabel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MHRlabel1.ForeColor = Color.Lavender;
            MHRlabel1.Location = new Point(167, 79);
            MHRlabel1.Name = "MHRlabel1";
            MHRlabel1.Size = new Size(433, 41);
            MHRlabel1.TabIndex = 0;
            MHRlabel1.Text = "Maximum heart Rate Calculator";
            // 
            // MHRlabel2
            // 
            MHRlabel2.AutoSize = true;
            MHRlabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MHRlabel2.ForeColor = Color.Lavender;
            MHRlabel2.Location = new Point(225, 165);
            MHRlabel2.Name = "MHRlabel2";
            MHRlabel2.Size = new Size(47, 28);
            MHRlabel2.TabIndex = 1;
            MHRlabel2.Text = "Age";
            MHRlabel2.Click += label2_Click;
            // 
            // MHRtextBox1
            // 
            MHRtextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MHRtextBox1.Location = new Point(321, 165);
            MHRtextBox1.Margin = new Padding(3, 4, 3, 4);
            MHRtextBox1.Name = "MHRtextBox1";
            MHRtextBox1.Size = new Size(242, 34);
            MHRtextBox1.TabIndex = 2;
            // 
            // MHRbutton1
            // 
            MHRbutton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MHRbutton1.ForeColor = Color.Coral;
            MHRbutton1.Location = new Point(167, 273);
            MHRbutton1.Margin = new Padding(3, 4, 3, 4);
            MHRbutton1.Name = "MHRbutton1";
            MHRbutton1.Size = new Size(126, 43);
            MHRbutton1.TabIndex = 3;
            MHRbutton1.Text = "Calculate";
            MHRbutton1.UseVisualStyleBackColor = true;
            MHRbutton1.Click += MHRbutton1_Click;
            // 
            // MHRtextBox2
            // 
            MHRtextBox2.Location = new Point(321, 251);
            MHRtextBox2.Margin = new Padding(3, 4, 3, 4);
            MHRtextBox2.Multiline = true;
            MHRtextBox2.Name = "MHRtextBox2";
            MHRtextBox2.Size = new Size(242, 139);
            MHRtextBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(167, 342);
            button1.Name = "button1";
            button1.Size = new Size(126, 39);
            button1.TabIndex = 9;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MHR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 25, 255);
            ClientSize = new Size(706, 458);
            Controls.Add(button1);
            Controls.Add(MHRtextBox2);
            Controls.Add(MHRbutton1);
            Controls.Add(MHRtextBox1);
            Controls.Add(MHRlabel2);
            Controls.Add(MHRlabel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MHR";
            Text = "MHR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MHRlabel1;
        private Label MHRlabel2;
        private TextBox MHRtextBox1;
        private Button MHRbutton1;
        private TextBox MHRtextBox2;
        private Button button1;
    }
}