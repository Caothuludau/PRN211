using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using CarGUI.Model;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace CarGUI
{
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            // get username and password from the form
            string user = textBox_User.Text;
            string password = textBox_Password.Text;
            if (user.Trim() == "") { MessageBox.Show("Please enter user!"); }
            if (password.Trim() == "") { MessageBox.Show("Please enter password!"); }
            //get admin username and password from json
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var configAccountConfig = config.GetSection("AdminAccount");
            AdminAccount adminAccount = configAccountConfig.Get<AdminAccount>();

            //compare and get the login result
            if (adminAccount != null)
            {
                if (user.Equals(adminAccount.User) && password.Equals(adminAccount.Password))
                {
                    MessageBox.Show("Login success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Login failed!");
                }
            }
            else
            {
                MessageBox.Show("You cannot login as admin right now. Please contact DEV!");
            }

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
