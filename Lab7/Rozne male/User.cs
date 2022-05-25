using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Rozne_male
{
    internal class User
    {
        string Username = "";
        string Password = "";
        int Id = -1;

        public User(int Id, string Username, string Password)
        {
            this.Id = Id;
            this.Username = Username;
            this.Password = Password;

        }
    }
}
