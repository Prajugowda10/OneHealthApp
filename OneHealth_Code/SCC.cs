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
    public partial class SCC : Form
    {
        public SCC()
        {
            InitializeComponent();
        }




        private void SCCbutton1_Click_1(object sender, EventArgs e)
        {
            double Days = Convert.ToDouble(SCCtextBox1.Text);
            double Noofcigarettes = Convert.ToDouble(SCCtextBox2.Text);


            if (Days <= 0 || Noofcigarettes <= 0)
            {
                throw new ArgumentException("Days and Number of Cigarettes should be greater than Zero!");
            }

            double Calculate = (Days * 10 * Noofcigarettes) / 20;
            SCCtextBox3.Text = "Your Smoking cost is : " + Calculate.ToString("#.#") + "Pounds";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Calculator Calculator = new Calculator();
            Calculator.Show();
        }
    }
}
