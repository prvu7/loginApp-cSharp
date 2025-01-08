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

namespace login_database_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listBoxUser.Items.Add("Username-ul trebuie sa contina:");
            listBoxUser.Items.Add("* Minim 6 caractere");
            listBoxUser.Items.Add("* Un caracter special");
            listBoxPass.Items.Add("Parola trebuie sa contina:");
            listBoxPass.Items.Add("* Minim 6 caractere");
            listBoxPass.Items.Add("* O litera mare");
            listBoxPass.Items.Add("* Un caracter special sau o cifra");
        }

        private void textBoxUser_MouseEnter(object sender, EventArgs e)
        {
            listBoxUser.Visible = true;
        }

        private void textBoxUser_MouseLeave(object sender, EventArgs e)
        {
            listBoxUser.Visible = false;
        }

        private void textBoxUser_Click(object sender, EventArgs e)
        {
            textBoxUser.Text = "";
            textBoxUser.ForeColor = Color.Black;
        }

        private void textBoxPass_MouseEnter(object sender, EventArgs e)
        {
            listBoxPass.Visible = true;
        }

        private void textBoxPass_MouseLeave(object sender, EventArgs e)
        {
            listBoxPass.Visible = false;
        }

        private void textBoxPass_Click(object sender, EventArgs e)
        {
            textBoxPass.Text = "";
            textBoxPass.ForeColor = Color.Black;
            textBoxPass.PasswordChar = '*';
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
            {
                textBoxPass.PasswordChar = '\0';
            }
            else
            {
                textBoxPass.PasswordChar = '*';
            }
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text;
            string password = textBoxPass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password!");
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=GEOHP;Initial Catalog=login_database_app;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();

                string insertQuery = "INSERT INTO login_database_app (username, password) VALUES (@username, @password)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0 && (checkBox1.CheckState == CheckState.Checked && checkBox2.CheckState == CheckState.Checked))
                    {
                        MessageBox.Show("Sign up successful!");
                    }
                    else
                    {
                        MessageBox.Show("Sign up failed. Please try again.");
                    }
                }
            }
        }
    }
}
