using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace OneHealth
{
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();


        }







        private void BMIbutton1_Click(object sender, EventArgs e)
        {

            double weight = Convert.ToDouble(BMItextBox2.Text);
            double height = Convert.ToDouble(BMItextBox1.Text);


            if (height <= 0 || weight <= 0)
            {
                throw new ArgumentException("Weight and Height should be greater than Zero!");
            }

            double Calculate = weight / (height * height);
            if (Calculate <= 0 || Calculate > 18.5)
            {
                BMItextBox3.Text = "You are Underweight and Your BMI is : " + Calculate.ToString("#.#");
            }
            else if (Calculate <= 18.5 || Calculate > 24.9)
            {
                BMItextBox3.Text = "You are Normalweight and Your BMI is : " + Calculate.ToString("#.#");
            }
            else if (Calculate <= 24.9 || Calculate > 29.9)
            {
                BMItextBox3.Text = "You are Overweight and Your BMI is : " + Calculate.ToString("#.#");
            }
            else
            {
                BMItextBox3.Text = "You are Obeese!! and Your BMI is : " + Calculate.ToString("#.#");
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


