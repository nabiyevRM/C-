using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromAe_App.Models
{
    class OrderModel
    {
        public string Order_UserName { get; set; }
        public string Order_UserSurname { get; set; }
        public string ProductName { get; set; }
        public string Product_Model { get; set; }
        public string Product_Price { get; set; }
        public DateTime Order_Date { get; set; }
    }
}
