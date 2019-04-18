using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using helpdesk_service.Models;
using helpdesk_service.ServicesControl;
using helpdesk_service;
using helpdesk_service.Gui_Databases;

namespace helpdesk_service
{
    public partial class ServicesListForm : Form
    {
        Helpdesk_services helpdesk_gird;
        public ServicesListForm()
        {
            InitializeComponent();
            helpdesk_gird = new Helpdesk_services();
        }

        private void ServicesListForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // adding services to datagrid //
            using (AddServiceForm add_service = new AddServiceForm(null, null) { service_model = new Services_Model() })
            {
                if (add_service.ShowDialog() == DialogResult.OK)
                    servicesModelBindingSource2.Add(add_service.service_model);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // removes services from datagrid //
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // edit rows in datagrid //
            var row = this.dataGridView1.SelectedRows[0];
            using (AddServiceForm add_service = new AddServiceForm(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString()) { service_model = new Services_Model() })
            {
                if (add_service.ShowDialog() == DialogResult.OK)
                    servicesModelBindingSource2.Add(add_service.service_model);
            }
            linkLabel2_LinkClicked(null, null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            AdminManagementForm admin_form = new AdminManagementForm();
            admin_form.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
