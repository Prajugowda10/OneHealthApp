using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneHealth
{
    public partial class DCI : Form
    {
        public DCI()
        {
            InitializeComponent();
        }

        private void BMRbutton1_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(DCItextBox2.Text);
            double height = Convert.ToDouble(DCItextBox1.Text);
            int age = Convert.ToInt32(DCItextBox2.Text);

            if (height <= 0 || weight <= 0 || age <= 0)
            {
                throw new ArgumentException("Weight and Height should be greater than Zero!");
            }

            if (DCIradioButton1.Checked)
            {
                if (DCIcheckBox1.Checked)
                {
                    double BMR = 66.5 + ((13.75 * weight) + (5.003 * height) - (6.75 * age));
                    double Calories = BMR * 1.2;
                    DCItextBox4.Text = "Your Daily Calorie need is " + Calories.ToString("#.#");
                }
                else if (DCIcheckBox2.Checked)
                {
                    double BMR = 66.5 + ((13.75 * weight) + (5.003 * height) - (6.75 * age));
                    double Calories = BMR * 1.375;
                    DCItextBox4.Text = "Your Daily Calorie need is " + Calories.ToString("#.#");
                }
                else if (DCIcheckBox3.Checked)
                {
                    double BMR = 66.5 + ((13.75 * weight) + (5.003 * height) - (6.75 * age));
                    double Calories = BMR * 1.55;
                    DCItextBox4.Text = "Your Daily Calorie need is " + Calories.ToString("#.#");
                }
                else if (DCIcheckBox4.Checked)
                {
                    double BMR = 66.5 + ((13.75 * weight) + (5.003 * height) - (6.75 * age));
                    double Calories = BMR * 1.725;
                    DCItextBox4.Text = "Your Daily Calorie need is " + Calories.ToString("#.#");
                }
                else if (DCIcheckBox5.Checked)
                {
                    double BMR = 66.5 + ((13.75 * weight) + (5.003 * height) - (6.75 * age));
                    double Calories = BMR * 1.9;
                    DCItextBox4.Text = "Your Daily Calorie need is " + Calories.ToString("#.#");
                }
                else
                {
                    DCItextBox4.Text = "Please selct any One Activity!";
                }

            }
            else if (DCIradioButton2.Checked)
            {
                if (DCIcheckBox1.Checked)
                {
                    double BMR = 655.1 + ((9.563 * weight) + (1.850 * height) - (4.676 * age));
                    double Calories = BMR * 1.2;
                    DCItextBox4.Text = "Your Daily Calorie need is " + Calories.ToString("#.#");
                }
                else if (DCIcheckBox2.Checked)
                {
                    double BMR = 655.1 + ((9.563 * weight) + (1.850 * height) - (4.676 * age));
                    double Calories = BMR * 1.375;
                    DCItextBox4.Text = "Your Daily Calorie need is " + Calories.ToString("#.#");
                }
                else if (DCIcheckBox3.Checked)
                {
                    double BMR = 655.1 + ((9.563 * weight) + (1.850 * height) - (4.676 * age));
                    double Calories = BMR * 1.55;
                    DCItextBox4.Text = "Your Daily Calorie need is " + Calories.ToString("#.#");
                }
                else if (DCIcheckBox4.Checked)
                {
                    double BMR = 655.1 + ((9.563 * weight) + (1.850 * height) - (4.676 * age));
                    double Calories = BMR * 1.725;
                    DCItextBox4.Text = "Your Daily Calorie need is " + Calories.ToString("#.#");
                }
                else if (DCIcheckBox5.Checked)
                {
                    double BMR = 655.1 + ((9.563 * weight) + (1.850 * height) - (4.676 * age));
                    double Calories = BMR * 1.9;
                    DCItextBox4.Text = "Your Daily Calorie need is " + Calories.ToString("#.#");
                }
                else
                {
                    DCItextBox4.Text = "Please selct any One Activity!";
                }
            }
            else
            {
                DCItextBox4.Text = " Please select any Gender!";
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
