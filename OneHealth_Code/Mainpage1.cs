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
    public partial class Mainpage1 : Form
    {
        public Mainpage1()
        {
            InitializeComponent();
        }

        private void MP1linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn SignIn = new SignIn();
            SignIn.Show();
        }

        private void MP1linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register Register = new Register();
            Register.Show();
        }

        private void MP1label1_Click(object sender, EventArgs e)
        {

        }
    }
}
