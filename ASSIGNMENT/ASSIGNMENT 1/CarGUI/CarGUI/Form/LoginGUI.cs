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
        public CarGUI carGUI { get; set; }
        public LoginGUI(CarGUI carGUI)
        {
            InitializeComponent();
            this.carGUI = carGUI;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            // get username and password from the form
            string user = textBox_User.Text;
            string password = textBox_Password.Text;
            if (user.Trim() == "") { MessageBox.Show("Please enter user!"); }
            else if (password.Trim() == "") { MessageBox.Show("Please enter password!"); }

            //get admin username and password from json
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var configAccountConfig = config.GetSection("AdminAccount");
            AdminAccount adminAccount = configAccountConfig.Get<AdminAccount>();

            //compare and get the login result
            if (adminAccount != null)
            {
                if (user.Equals(adminAccount.User) && password.Equals(adminAccount.Password))
                {
                    Authentication.isAdmin = true;
                    carGUI.Reload();
                    MessageBox.Show("Login success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
