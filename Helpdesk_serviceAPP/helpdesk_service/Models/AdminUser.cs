using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpdesk_service.Models
{
    static class AdminUser
    {
        private static string adminEmail = "admin@gmail.com";
        private static string adminPassword = "admin123";

        public static string AdminEmail { get { return adminEmail; } }
        public static string AdminPassword { get{ return adminPassword; } }
    }
}
