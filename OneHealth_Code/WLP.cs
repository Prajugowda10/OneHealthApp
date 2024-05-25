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
    public partial class WLP : Form
    {
        public WLP()
        {
            InitializeComponent();
        }

        private void WLPbutton1_Click(object sender, EventArgs e)
        {
            double Lost_Weight = Convert.ToDouble(WLPtextBox1.Text);
            double Starting_Weight = Convert.ToDouble(WLPtextBox2.Text);


            if (Lost_Weight <= 0 || Starting_Weight <= 0)
            {
                throw new ArgumentException("Lost_Weight and Starting_Weight should be greater than Zero!");
            }

            double Calculate = (Lost_Weight / Starting_Weight) * 100;
            WLPtextBox3.Text = "Your Weight loss Percentage is : " + Calculate.ToString("#.#") + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Calculator Calculator = new Calculator();
            Calculator.Show();
        }
    }
}
