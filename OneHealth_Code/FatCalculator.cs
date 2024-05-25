using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneHealth
{
    public partial class FatCalculator : Form
    {
        public FatCalculator()
        {
            InitializeComponent();
        }

        private void fcbutton1_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(fctextBox3.Text);
            double height = Convert.ToDouble(fctextBox2.Text);
            int age = Convert.ToInt32(fctextBox1.Text);


            if (height <= 0 || weight <= 0 || age <= 0)
            {
                throw new ArgumentException("Weight,Age and Height should be greater than Zero!");
            }

            if (fcradioButton1.Checked)
            {
                double BMI = weight / (height * height);
                double Calculate = ((1.20 * BMI) + (0.23 * age) - 16.2);
                fctextBox4.Text = "Your Body Fat Percentage is " + Calculate.ToString("#.#") + "%";
            }
            else
            if (fcradioButton2.Checked) { }
            {
                double BMI = weight / (height * height);
                double Calculate = ((1.20 * BMI) + (0.23 * age) - 5.4);
                fctextBox4.Text = "Your Body Fat Percentage is " + Calculate.ToString("#.#") + "%";
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
