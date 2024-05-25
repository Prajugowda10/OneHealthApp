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
    public partial class Nextpage : Form
    {
        public Nextpage()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Calculator Calculator = new Calculator();
            Calculator.Show();
        }

        private void Nextpage_Load(object sender, EventArgs e)
        {

        }
    }
}
