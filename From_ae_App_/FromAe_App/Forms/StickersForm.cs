using Admin_Form.Core;
using Admin_Form.Models;
using FromAe_App.Forms;
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

namespace Admin_Form.Forms
{
    public partial class StickersForm : Form
    {
        public StickersForm()
        {
            InitializeComponent();
            
        }

        // product list container which procuder geted from databse //
        List<Product> container;

        // pagination procedure variables //
        int from = 0;
        int to = 4;

        // counter for pagination algorithm //
        int counter = 0;

        private void StickersForm_Load(object sender, EventArgs e)
        {
            // pagination procedure string variables //
            btn_close_form.Visible = false;
            string _from = from + "";
            string _to = to + "";
            // getting data from database //
            DbSet<Product> products = new DbSet<Product>();
            string connection = ConfigurationManager.ConnectionStrings["FromAeDB"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand($"pagination {_from},{_to}", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                products.Add(new Product()
                {
                    Product_Id = sqlDataReader["ProductID"].ToString(),
                    Product_Name = sqlDataReader["ProductName"].ToString(),
                    Price = sqlDataReader["Price"].ToString(),
                    Photo_Path = sqlDataReader["PhotoPath"].ToString()
                });
            }
            // product data which pagination procedure geted //
            container = products.GetAllData();

            // gets stickers photo directory //
            string directory = Directory.GetCurrentDirectory();
            DirectoryInfo drInfo = new DirectoryInfo(directory);
            string folderDirectory = drInfo.Parent.Parent.Parent.FullName +"/images/";

            // pagination codes //
            for (int i = 0; i < container.Count; i++)
            {
                StickerBox box = new StickerBox();
                // hide product id //
                box.product_id.Visible = false;

                if (counter % 2 == 0 && counter == 0)
                {
                    box.Location = new Point(11, 11);
                    box.lbl_product_name.Text = container[0].Product_Name;
                    box.lbl_product_price.Text = container[0].Price;
                    box.stickerPhoto.ImageLocation = folderDirectory + container[0].Photo_Path;
                    box.product_id.Text = container[0].Product_Id;
                    stickersBox.Controls.Add(box);
                }
                else if (counter % 2 == 0)
                {
                    box.Location = new Point(11, 245);
                    box.lbl_product_name.Text = container[2].Product_Name;
                    box.lbl_product_price.Text = container[2].Price;
                    box.stickerPhoto.ImageLocation = folderDirectory + container[2].Photo_Path;
                    box.product_id.Text = container[2].Product_Id;
                    stickersBox.Controls.Add(box);
                }
                else if (counter % 1 == 0 && counter % 3 != 0)
                {
                    box.Location = new Point(200, 11);
                    box.lbl_product_name.Text = container[1].Product_Name;
                    box.lbl_product_price.Text = container[1].Price;
                    box.stickerPhoto.ImageLocation = folderDirectory + container[1].Photo_Path;
                    box.product_id.Text = container[1].Product_Id;
                    stickersBox.Controls.Add(box);
                }
                else
                {
                    box.Location = new Point(194, 245);
                    box.lbl_product_name.Text = container[3].Product_Name;
                    box.lbl_product_price.Text = container[3].Price;
                    box.stickerPhoto.ImageLocation = folderDirectory + container[3].Photo_Path;
                    box.product_id.Text = container[3].Product_Id;
                    stickersBox.Controls.Add(box);
                }
                counter++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // next pagination gettind data from database //
            container.Clear();
            stickersBox.Controls.Clear();
            from += 4;
            counter = 0;

            StickersForm_Load(sender, e);
            if (counter == 0)
            {
                btn_back_Click(sender, e);
                MessageBox.Show("Növbəti səhifədə elan mövcüd deyil.");
            }
                
        }

        
        private void btn_back_Click(object sender, EventArgs e)
        {
            // back pagination gettind data from database //
            if (from > 0)
            {
                container.Clear();
                stickersBox.Controls.Clear();
                from -= 4;
                counter = 0;

                StickersForm_Load(sender, e);
                stickersBox.Visible = false;
                stickersBox.Show();
            } 
        }
        public void button1_Click_1(object sender, EventArgs e)
        {
            ProductDetails s = new ProductDetails();
            s.Show();
        }

        public void btn_close_form_Click(object sender, EventArgs e)
        {
            ProductDetails s = new ProductDetails();
            s.Show();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            FormCover cover = new FormCover();
            cover.Show();
            this.Visible = false;
        }

        private void stickersBox_Enter(object sender, EventArgs e)
        {

        }

        private void StickersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
