using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AistGroup_IT_Company.Models;

namespace AistGroup_IT_Company.Gui
{
    static class UserDB
    {
        private static ArrayList UserData = new ArrayList();
        private static int counter = 0;

        public static ArrayList AddUser(User user)
        {
            UserData.Add(user);
            return UserData;
        }

        public static ArrayList GetAllData()
        {
            return UserData;
        }
    }
}
