using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AistGroup_IT_Company.Models
{
    class User
    {
        private string name;
        private string surname;
        private string email;
        private string password;
        private string confirm_password;

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Confirm_Password { get { return confirm_password; } set { confirm_password = value; } }
    }
}
