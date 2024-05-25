using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OneHealth
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void MP2button1_Click(object sender, EventArgs e)
        {
            SignIn SignIn = new SignIn();
            SignIn.ShowDialog();
            if (ValidateUser(MP2textBox1.Text, MP2textBox2.Text))
            {
                MessageBox.Show("Login successful!");


                // You can navigate to another form or perform other actions here.
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private bool ValidateUser(string Username, string Password)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=PRAJWALPC;Initial Catalog=OneHealth;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }



        }

        private void MP2linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn SignIn = new SignIn();
            SignIn.Show();
        }
    }
}
