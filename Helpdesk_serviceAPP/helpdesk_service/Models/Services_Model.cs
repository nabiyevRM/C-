using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpdesk_service.Models
{
    public class Services_Model
    {
        private string service_name;
        private string service_price;
        private string service_id;

        public string Service_Name { get { return service_name; } set { service_name = value; } }
        public string Service_Price { get { return service_price; } set { service_price = value; } }
        public string Service_ID { get { return service_id; } set { service_id = value; } }
    }
}
