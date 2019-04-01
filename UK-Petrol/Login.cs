using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UK_Petrol
{
    public partial class Login : Form
    {
        public string[,] users = new string[,] {
            {"Mohsen", "1234567890"},
            {"Wolf", "0987654321"},
            {"admin", "admin"}
        };
        public Login()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void loginBttn_Click(object sender, EventArgs e)
        {
            if (userNameBox.Text == "")
            {
                label5.Text = "User name Cannot be empty";
                return;
            }
            if (passwordBox.Text == "")
            {
                label6.Text = "Password cannot be empty";
                return;
            }
            for (int rows = 0; rows < users.GetLongLength(0); rows++)
            {
                for (int cols = 0; cols < users.GetLongLength(1); cols++)
                {
                    if (users[rows, 0] == userNameBox.Text && users[rows, 1] == passwordBox.Text)
                    {
                        Form mainform = new mainForm();
                        mainform.Show();
                        this.Hide();
                        return;
                    }
                    else
                        label4.Text = "Wrong user name or password";
                }
            }
        }
        private void label1_Click(object sender, EventArgs e) { }

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "";
            label6.Text = "";
            label5.Text = "";
        }
        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "";
            label6.Text = "";
            label5.Text = "";
        }

        private void Login_Load(object sender, EventArgs e) { }
    }
}
