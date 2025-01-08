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
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace login_database_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxUsername.TabStop = false;
            textBoxPassw.TabStop = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=GEOHP;Initial Catalog=login_database_app;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            string loginQuery = "SELECT COUNT(*) FROM login_database_app WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(loginQuery, con);

            string username = textBoxUsername.Text;
            string password = textBoxPassw.Text;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            int count = (int)cmd.ExecuteScalar();
            if(count > 0)
            {
                MessageBox.Show("Login Succefully!");
            }
            else
            {
                MessageBox.Show("Login Unsuccefully!");
            }
        }

        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin.Size = new Size(buttonLogin.Width + 2, buttonLogin.Height + 2);
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.Size = new Size(buttonLogin.Width - 2, buttonLogin.Height - 2);
        }

        private void checkBoxPassw_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxPassw.Checked){
                textBoxPassw.PasswordChar = '\0';
            }
            else {
                textBoxPassw.PasswordChar = '*';
            }
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxUsername.ForeColor = Color.Black;
        }

        private void textBoxPassw_Click(object sender, EventArgs e)
        {
            textBoxPassw.Text = "";
            textBoxPassw.ForeColor = Color.Black;
            textBoxPassw.PasswordChar = '*';
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
        }
    }
}
