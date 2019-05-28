using Admin_Form.Core;
using Admin_Form.Models;
using FromAe_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Form.Forms
{
    public partial class ProductDetails : Form
    {
        public ProductDetails()
        {
            InitializeComponent();
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            UsingDB usingDB = new UsingDB();

            // getting form user name and surname //

            lbl_form_user.Text = Form_User.Name + " " + Form_User.Surname;

            // getting chosed product all data when ream more button cliced //

            int productID = GetID.Id;
            string procedure = $"GetProductDetails {productID}";
            List<ProductSpecification> chosedProduct = usingDB.GetProductDetails("FromAeDB", procedure);
            usingDB.DisposeSeans();

            // gets stickers photo directory //
            string directory = Directory.GetCurrentDirectory();
            DirectoryInfo drInfo = new DirectoryInfo(directory);
            string folderDirectory = drInfo.Parent.Parent.Parent.FullName + "/images/";

            // fill all product data to order control //

            OrderProductControl order = new OrderProductControl();
            order.product_photo.ImageLocation = folderDirectory + chosedProduct[0].Product_Photo;
            order.lbl_pro_name.Text = chosedProduct[0].Product_Name.ToString();
            order.lbl_pro_price.Text = chosedProduct[0].Product_Price.ToString();
            order.lbl_model.Text = chosedProduct[0].Model.ToString();
            order.lbl_color.Text = chosedProduct[0].Color.ToString();
            order.lbl_size.Text = chosedProduct[0].Size.ToString();
            order.lbl_card_count.Text = chosedProduct[0].Cards_Count.ToString();
            order.lbl_inner_storage.Text = chosedProduct[0].Inner_Storage.ToString();
            order.lbl_ram.Text = chosedProduct[0].Ram.ToString();
            order.lbl_front_camera.Text = chosedProduct[0].Front_Camera.ToString();
            order.lbl_back_camera.Text = chosedProduct[0].Back_Camera.ToString();
            order.lbl_battery_volume.Text = chosedProduct[0].Battery_Volume.ToString();
            order.Location = new Point(5, 25);
            productBox.Controls.Add(order);
            
        }

        private void productBox_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_page_Click(object sender, EventArgs e)
        {
            StickersForm stickers = new StickersForm();
            stickers.Show();
            this.Visible = false;
        }

        private void ProductDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
