using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGUI.Model
{
    internal class AdminAccount
    {
        public string? User {get; set;}
        public string? Password { get; set;}    

        public AdminAccount() { }

        public AdminAccount(string? user, string? password)
        {
            User = user;
            Password = password;
        }
    }
}
