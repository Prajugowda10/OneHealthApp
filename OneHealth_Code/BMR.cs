namespace OneHealth
{
    public partial class BMR : Form
    {
        public BMR()
        {
            InitializeComponent();
        }

        private void BMRbutton1_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(BMRtextBox2.Text);
            double height = Convert.ToDouble(BMRtextBox1.Text);
            int age = Convert.ToInt32(BMRtextBox2.Text);

            if (height <= 0 || weight <= 0 || age <= 0)
            {
                throw new ArgumentException("Weight and Height should be greater than Zero!");
            }

            if (BMRradioButton1.Checked)
            {
                double Calculate = 66.5 + ((13.75 * weight) + (5.003 * height) - (6.75 * age));
                BMRtextBox4.Text = "Your Basal Meatbolic rate is " + Calculate.ToString("#.#") + " Do you want to know Your daily calorie Need?";
            }
            else
            if (BMRradioButton2.Checked) { }
            {
                double Calculate = 655.1 + ((9.563 * weight) + (1.850 * height) - (4.676 * age));
                BMRtextBox4.Text = "Your Basal Meatbolic rate is " + Calculate.ToString("#.#") + " Do you want to know Your daily calorie Need?";

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Calculator Calculator = new Calculator();
            Calculator.Show();
        }
    }
}
