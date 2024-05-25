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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void ClinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WI WI = new WI();
            WI.Show();
        }

        private void ClinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BMR BMR = new BMR();
            BMR.Show();
        }

        private void ClinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CC CC = new CC();
            CC.Show();
        }

        private void ClinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MHR MHR = new MHR();
            MHR.Show();
        }

        private void ClinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IBW IBW = new IBW();
            IBW.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DCI DCI = new DCI();
            DCI.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void ClinkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SCC SCC = new SCC();
            SCC.Show();
        }

        private void ClinkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WGC WGC = new WGC();
            WGC.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WLP WLP = new WLP();
            WLP.Show();
        }

        private void ClinkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FatCalculator FatCalculator = new FatCalculator();
            FatCalculator.Show();
        }

        private void ClinkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BMI BMI = new BMI();
            BMI.Show();
        }

        private void ClinkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WTH WTH = new WTH();
            WTH.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
