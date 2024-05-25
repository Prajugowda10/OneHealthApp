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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void MP3linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register Register = new Register();
            Register.Show();
        }

        private void MP3button1_Click(object sender, EventArgs e)
        {
            Nextpage Nextpage = new Nextpage();
            Nextpage.Show();
        }

        private void MP3button2_Click(object sender, EventArgs e)
        {
            MP3textBox1.Text = string.Empty;
            MP3textBox2.Text = string.Empty;
        }
    }
}
