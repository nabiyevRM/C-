using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using helpdesk_service.Models;

namespace helpdesk_service.Gui_Databases
{
    static class UserDatabase
    {
        private static ArrayList UserDB = new ArrayList();

        public static ArrayList AddUser(UserModel user)
        {
            UserDB.Add(user);
            return UserDB;
        }

        public static ArrayList GetAllUsersData()
        {
            return UserDB;
        }
    }
}
