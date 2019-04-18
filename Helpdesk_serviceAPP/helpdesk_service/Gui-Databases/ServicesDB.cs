using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using helpdesk_service.Models;

namespace helpdesk_service.Gui_Databases
{
    static class ServicesDB
    {
        private static ArrayList ServiceDB = new ArrayList();

        public static ArrayList AddServices(Services_Model service)
        {
            ServiceDB.Add(service);
            return ServiceDB;
        }

        public static ArrayList GetAllServices()
        {
            return ServiceDB;
        }
    }
}
