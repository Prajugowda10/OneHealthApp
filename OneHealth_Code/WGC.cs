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
    public partial class WGC : Form
    {
        public WGC()
        {
            InitializeComponent();
        }

        private void WGCtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WGCbutton1_Click(object sender, EventArgs e)
        {
            double Current_weight = Convert.ToDouble(WGCtextBox1.Text);
            double Target_weight = Convert.ToDouble(WGCtextBox2.Text);
            double No_of_days = Convert.ToDouble(WGCtextBox3.Text);

            if (Current_weight <= 0 || Target_weight <= 0 || No_of_days <= 0)
            {
                throw new ArgumentException("Current Weight,Target Weight and Days should be greater than Zero!");
            }

            double Weight = Target_weight - Current_weight;
            double Calculate = No_of_days * Weight;
            WGCtextBox4.Text = " Number of days required to gain target weight is " + Calculate.ToString("#.#") + "days";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Calculator Calculator = new Calculator();
            Calculator.Show();
        }
    }
}
