using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using Admin_Form.Models;
using Admin_Form.Forms;
using Admin_Form.Core;

namespace Admin_Form
{
    public partial class StickerBox : UserControl
    {
        public StickerBox()
        {
            InitializeComponent();
        }

        private void btn_read_more_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(product_id.Text);
            GetID.Id = productID;
            this.Parent.Parent.Hide();
            new StickersForm().btn_close_form_Click(sender,e);  
           
        }
    }
}
