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
    public partial class IBW : Form
    {
        public IBW()
        {
            InitializeComponent();
        }

        private void IBMbutton1_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(IBMtextBox2.Text);
            int age = Convert.ToInt32(IBMtextBox1.Text);


            if (height <= 0 || age <= 0)
            {
                throw new ArgumentException("Age and Height should be greater than Zero!");
            }

            if (IBMradioButton1.Checked)
            {

                double Calculate = (22 * (height * height));
                IBMtextBox3.Text = "Your Ideal Body Weight is " + Calculate.ToString("#.#") + "Kg";
            }
            else
            if (IBMradioButton2.Checked) { }
            {

                double Calculate = (22 * (height * height) - (0.10 * 0.10));
                IBMtextBox3.Text = "Your Ideal Body Weight is " + Calculate.ToString("#.#") + "Kg";
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
