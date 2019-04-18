using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using helpdesk_service.Gui_Databases;

namespace helpdesk_service.Models
{
    abstract class UserModel
    {
        private string name;
        private string surname;
        private string email;
        private string password;
        private string confirm_password;
        private string card_number;
        private DateTime cardUsedTime;

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Confirm_Password { get { return confirm_password; } set { confirm_password = value; } }
        public string Card_Number { get { return card_number; } set { card_number = value; } }
        public DateTime CardUsedTime { get { return cardUsedTime; } set { cardUsedTime = value; } }
    }
    
    class SimpleUser : UserModel
    {

    }

    class CardUser : UserModel
    {
        
    }
}
