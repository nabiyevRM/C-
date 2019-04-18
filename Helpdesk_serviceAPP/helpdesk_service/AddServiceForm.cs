using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using helpdesk_service.ServicesControl;
using helpdesk_service.Gui_Databases;
using helpdesk_service.Models;

namespace helpdesk_service
{
    public partial class AddServiceForm : Form
    {
        public Services_Model service_model { get; set; }
        public int id = 1;
        public AddServiceForm(string name, string price)
        {
            InitializeComponent();
            txbx_service_name.Text = name;
            txbx_service_price.Text = price;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            service_model.Service_Name = txbx_service_name.Text;
            service_model.Service_Price = txbx_service_price.Text;
            service_model.Service_ID = txbx_service_id.Text;
            
            ServicesDB.AddServices(service_model);
        }
    }
}
