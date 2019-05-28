using Admin_Form;
using FromAe_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromAe_App.Forms
{
    public partial class OrdersListForm : Form
    {
        public OrdersListForm()
        {
            InitializeComponent();
        }

        private void OrdersListForm_Load(object sender, EventArgs e)
        {
            UsingDB usingDB = new UsingDB();
            List<OrderModel> orders = usingDB.GetOrders("FromAeDB");
            dataGridView1.DataSource = orders;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 admin_form = new Form1();
            admin_form.Show();
            this.Visible = false;
        }

        private void OrdersListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
