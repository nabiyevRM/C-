using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpdesk_service.Models
{
    class Helpdesk_services
    {
        private string helpdesk_service_name;
        private string helpdesk_service_price;

        public string Helpdesk_Service_Name { get { return helpdesk_service_name; } set { helpdesk_service_name = value; } }
        public string Helpdesk_Service_Price { get { return helpdesk_service_price; } set { helpdesk_service_price = value; } }
    }
}
