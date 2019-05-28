using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_Form.Forms;

namespace Admin_Form
{
    public partial class OrderProductControl : UserControl
    {
        public OrderProductControl()
        {
            InitializeComponent();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Məhsulu sifariş etmək üçün qeydiyyatdan keçməlisiniz.");
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
            this.Parent.Parent.Visible = false;
        }
    }
}
