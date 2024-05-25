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
    public partial class CC : Form
    {
        public CC()
        {
            InitializeComponent();
        }


        private void CCbutton1_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(CCtextBox3.Text);
            double height = Convert.ToDouble(CCtextBox2.Text);
            int age = Convert.ToInt32(CCtextBox1.Text);

            if (height <= 0 || weight <= 0 || age <= 0)
            {
                throw new ArgumentException("Weight and Height should be greater than Zero!");
            }

            if (CCradioButton1.Checked)
            {
                if (CCcheckBox1.Checked)
                {
                    double minimumCarbIntake = weight * 2.5;
                    double maximumCarbIntake = weight * 2.8;
                    CCtextBox4.Text = "Your Minimum Carbintake is " + minimumCarbIntake.ToString("#.#") + " and your Maximum Carbintake is " + maximumCarbIntake.ToString("#.#");
                }
                else if (CCcheckBox2.Checked)
                {
                    double minimumCarbIntake = weight * 3.2;
                    double maximumCarbIntake = weight * 3.5;
                    CCtextBox4.Text = "Your Minimum Carbintake is " + minimumCarbIntake.ToString("#.#") + " and your Maximum Carbintake is " + maximumCarbIntake.ToString("#.#");
                }
                else if (CCcheckBox3.Checked)
                {
                    double minimumCarbIntake = weight * 3.5;
                    double maximumCarbIntake = weight * 3.8;
                    CCtextBox4.Text = "Your Minimum Carbintake is " + minimumCarbIntake.ToString("#.#") + " and your Maximum Carbintake is " + maximumCarbIntake.ToString("#.#");
                }
                else if (CCcheckBox4.Checked)
                {
                    double minimumCarbIntake = weight * 3.8;
                    double maximumCarbIntake = weight * 4.0;
                    CCtextBox4.Text = "Your Minimum Carbintake is " + minimumCarbIntake.ToString("#.#") + " and your Maximum Carbintake is " + maximumCarbIntake.ToString("#.#");
                }
                else if (CCcheckBox5.Checked)
                {
                    double minimumCarbIntake = weight * 4.1;
                    double maximumCarbIntake = weight * 4.3;
                    CCtextBox4.Text = "Your Minimum Carbintake is " + minimumCarbIntake.ToString("#.#") + " and your Maximum Carbintake is " + maximumCarbIntake.ToString("#.#");
                }
                else if (CCcheckBox6.Checked)
                {
                    double minimumCarbIntake = weight * 4.2;
                    double maximumCarbIntake = weight * 4.4;
                    CCtextBox4.Text = "Your Minimum Carbintake is " + minimumCarbIntake.ToString("#.#") + " and your Maximum Carbintake is " + maximumCarbIntake.ToString("#.#");
                }
                else
                {
                    CCtextBox4.Text = "Please select one of the activity level options!";
                }
            }

            else if (CCradioButton2.Checked)
            {
                if (CCcheckBox1.Checked)
                {
                    double minimumCarbIntake = weight * 2.4;
                    double maximumCarbIntake = weight * 2.7;
                    CCtextBox4.Text = "Your Minimum Carbintake is " + minimumCarbIntake.ToString("#.#") + " and your Maximum Carbintake is " + maximumCarbIntake.ToString("#.#");
                }
                else if (CCcheckBox2.Checked)
                {
                    double minimumCarbIntake = weight * 3.0;
                    double maximumCarbIntake = weight * 3.2;
                    CCtextBox4.Text = "Your Minimum Carbintake is " + minimumCarbIntake.ToString("#.#") + " and your Maximum Carbintake is " + maximumCarbIntake.ToString("#.#");
                }
                else if (CCcheckBox3.Checked)
                {
                    double minimumCarbIntake = weight * 3.3;
                    double maximumCarbIntake = weight * 3.5;
                    CCtextBox4.Text = "Your Minimum Carbintake is " + minimumCarbIntake.ToString("#.#") + " and your Maximum Carbintake is " + maximumCarbIntake.ToString("#.#");
                }
                else if (CCcheckBox4.Checked)
                {
                    double minimumCarbIntake = weight * 3.5;
                    double maximumCarbIntake = weight * 3.7;
                    CCtextBox4.Text = "Your Minimum Carbintake is " + minimumCarbIntake.ToString("#.#") + " and your Maximum Carbintake is " + maximumCarbIntake.ToString("#.#");
                }
                else if (CCcheckBox5.Checked)
                {
                    double minimumCarbIntake = weight * 3.9;
                    double maximumCarbIntake = weight * 4.1;
                    CCtextBox4.Text = "Your Minimum Carbintake is " + minimumCarbIntake.ToString("#.#") + " and your Maximum Carbintake is " + maximumCarbIntake.ToString("#.#");
                }
                else if (CCcheckBox6.Checked)
                {
                    double minimumCarbIntake = weight * 4.2;
                    double maximumCarbIntake = weight * 4.4;
                    CCtextBox4.Text = "Your Minimum Carbintake is " + minimumCarbIntake.ToString("#.#") + " and your Maximum Carbintake is " + maximumCarbIntake.ToString("#.#");
                }
                else
                {
                    CCtextBox4.Text = "Please select one of the activity level options!";
                }


            }
            else
            {
                CCtextBox4.Text = "Please Select one of the Gender Option!";
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
