using Admin_Form.Forms;
using FromAe_App.Forms;
using FromAe_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Admin_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // image location //
        string imageLocation = "";
        OpenFileDialog dialog;

        // specifications control object //
        SpeficationsControl spefications = new SpeficationsControl();

        private void button1_Click(object sender, EventArgs e)
        {
            // display photo on form and gets image location//
            dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(.*jpg)|.*jpg| PNG files(.*png)|.*png| All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName;
                pictureBox_product.ImageLocation = imageLocation.ToString();
            }        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // adding specification control to specification group box //
            spefications.Location = new Point(5, 15);
            groupBox_spefication.Controls.Add(spefications);

            // showing submit button //
            btn_submit.Visible = true;

            // copy image to photos folder //
            FileInfo fileInfo = new FileInfo(dialog.FileName);
            string source = Environment.CurrentDirectory + "/images" + "/" + fileInfo.Name;
            File.Copy(dialog.FileName, source);

            // adding product photo,name and price to database //
            UsingDB usingDB = new UsingDB();
            usingDB.ConnectDB("FromAeDB");
            string values = $"'{txbx_product_name.Text}','{txbx_product_price.Text}','{fileInfo.Name.ToString()}'";
            usingDB.InsertToDB("Products", values);
            usingDB.DisposeSeans();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_submit.Visible = false;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            // getting product id for specification,this table need for foreign key //
            UsingDB usingDB = new UsingDB();
            int id = usingDB.GetID("FromAeDB", "GetID", "ProductID");

            // adding product specifications to specifications table //
            usingDB.ConnectDB("FromAeDB");
            string querry = $"'{spefications.txbx_model.Text}','{spefications.txbx_color.Text}','{spefications.txbx_sizes.Text}','{spefications.txbx_cards_count.Text}'," +
            $"'{spefications.txbx_inner_storage.Text}','{spefications.txbx_ram.Text}','{spefications.txbx_front_camera.Text}','{spefications.txbx_back_camera.Text}','{spefications.txbx_battery_volume.Text}','{id}'";
            usingDB.InsertToDB("ProductSpefications", querry);
            usingDB.DisposeSeans();
            MessageBox.Show("Elan uğurla paylaşıldı."+"\n" +"Elanlar formundan son elana baxa bilərsiz.");
            Form1 f = new Form1();
            f.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StickersForm stickersForm = new StickersForm();
            stickersForm.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCover cover = new FormCover();
            cover.Show();
            this.Visible = false;
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            OrdersListForm orders = new OrdersListForm();
            orders.Show();
            this.Visible = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void update_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminsStickers stickersEdit = new AdminsStickers();
            stickersEdit.Show();
            this.Visible = false;
        }
    }
}
