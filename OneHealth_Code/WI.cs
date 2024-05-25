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
    public partial class WI : Form
    {
        public WI()
        {
            InitializeComponent();
        }

        private void WIbutton1_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(WItextBox1.Text);



            if (weight <= 0)
            {
                throw new ArgumentException("Weight and Height should be greater than Zero!");
            }

            if (WIcheckBox1.Checked)
            {
                double Calculate = 0.8;
                WItextBox4.Text = "Your daily water Intake should be : " + Calculate.ToString("#.#") + "ltrs";
            }
            else if (WIcheckBox2.Checked)
            {
                double Calculate = 1.0;
                WItextBox4.Text = "Your daily water Intake should be : " + Calculate.ToString("#.#") + "ltrs";
            }
            else if (WIcheckBox3.Checked)
            {
                double Calculate = 1.3;
                WItextBox4.Text = "Your daily water Intake should be : " + Calculate.ToString("#.#") + "ltrs";
            }
            else if (WIcheckBox4.Checked)
            {
                double Calculate = 1.7;
                WItextBox4.Text = "Your daily water Intake should be : " + Calculate.ToString("#.#") + "ltrs";
            }
            else if (WIcheckBox5.Checked)
            {
                double Calculate = 2.4;
                WItextBox4.Text = "Your daily water Intake should be : " + Calculate.ToString("#.#") + "ltrs";
            }
            else if (WIcheckBox6.Checked)
            {
                double Calculate = 2.1;
                WItextBox4.Text = "Your daily water Intake should be : " + Calculate.ToString("#.#") + "ltrs";
            }
            else if (WIcheckBox7.Checked)
            {
                double Calculate = 3.3;
                WItextBox4.Text = "Your daily water Intake should be : " + Calculate.ToString("#.#") + "ltrs";
            }
            else if (WIcheckBox8.Checked)
            {
                double Calculate = 2.3;
                WItextBox4.Text = "Your daily water Intake should be : " + Calculate.ToString("#.#") + "ltrs";
            }
            else if (WIcheckBox9.Checked)
            {
                double Calculate = 3.7;
                WItextBox4.Text = "Your daily water Intake should be : " + Calculate.ToString("#.#") + "ltrs";
            }
            else if (WIcheckBox3.Checked)
            {
                double Calculate = 2.7;
                WItextBox4.Text = "Your daily water Intake should be : " + Calculate.ToString("#.#") + "ltrs";
            }
            else
            {
                WItextBox4.Text = "Please selct one of the age group!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Calculator Calculator = new Calculator();
            Calculator.Show();
        }
    }
}
