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
    public partial class WTH : Form
    {
        public WTH()
        {
            InitializeComponent();
        }

        private void WTHbutton1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(WTHtextBox1.Text, out double waist) && double.TryParse(WTHtextBox2.Text, out double hip))
            {
                if (waist <= 0 || hip <= 0)
                {
                    throw new ArgumentException("Days and Number of Cigarettes should be greater than Zero!");
                }
                else
                {
                    double calculate = waist / hip;
                    WTHtextBox3.Text = $" Your waist to hip ratio is {calculate:F2}";
                }
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






