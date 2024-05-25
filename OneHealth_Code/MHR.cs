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
    public partial class MHR : Form
    {
        public MHR()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MHRbutton1_Click(object sender, EventArgs e)
        {

            double Age = Convert.ToDouble(MHRtextBox1.Text);


            if (Age <= 0)
            {
                throw new ArgumentException("Weight and Height should be greater than Zero!");
            }

            double Calculate = 220 - Age;
            if (Calculate <= 171 || Calculate > 220)
            {
                double THR = Calculate * 90 / 100;
                MHRtextBox2.Text = "Your Maximum Heart rate is : " + Calculate.ToString("#.#") + " , your Target heart Rate is " + THR.ToString("#.#") + " and your heart is in maximum 'VO2(OXYGEN) Zone'.";
            }
            else if (Calculate <= 152 || Calculate > 171)
            {
                double THR = Calculate * 80 / 100;
                MHRtextBox2.Text = "Your Maximum Heart rate is : " + Calculate.ToString("#.#") + " , your Target heart Rate is " + THR.ToString("#.#") + " and your heart is in 'Anaerobic  Zone'.";
            }
            else if (Calculate <= 133 || Calculate > 152)
            {
                double THR = Calculate * 70 / 100;
                MHRtextBox2.Text = "Your Maximum Heart rate is : " + Calculate.ToString("#.#") + " , your Target heart Rate is " + THR.ToString("#.#") + " and your heart is in 'Aerobic Zone'.";
            }
            else if (Calculate <= 114 || Calculate > 133)
            {
                double THR = Calculate * 60 / 100;
                MHRtextBox2.Text = "Your Maximum Heart rate is : " + Calculate.ToString("#.#") + " , your Target heart Rate is " + THR.ToString("#.#") + " and your heart is in 'Fat Burn Zone'.";
            }
            else if (Calculate < 95 || Calculate > 114)
            {
                double THR = Calculate * 50 / 100;
                MHRtextBox2.Text = "Your Maximum Heart rate is : " + Calculate.ToString("#.#") + " , your Target heart Rate is " + THR.ToString("#.#") + " and your heart is in 'Warm Up Zone'.";
            }
            else
            {
                MHRtextBox2.Text = "You need to consult a Doctor Immediately!";
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
