using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AistGroup_IT_Company.Models
{
    class Login_User
    {
        private string login_email;
        private string login_password;

        public string Login_Email { get { return login_email; } set { login_email = value; } }
        public string Login_Password { get { return login_password; } set { login_password = value; } }
    }
}
