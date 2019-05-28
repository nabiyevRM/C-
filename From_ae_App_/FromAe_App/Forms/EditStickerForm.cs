using Admin_Form;
using FromAe_App.Core;
using FromAe_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromAe_App.Forms
{
    public partial class EditStickerForm : Form
    {
        public EditStickerForm()
        {
            InitializeComponent();
        }

        UsingDB usingDB;
        private void EditStickerForm_Load(object sender, EventArgs e)
        {
            // writing data to text boxes for edit //
            usingDB = new UsingDB();
            List<StickerModel> stickers = usingDB.GetStickerDataEdit("FromAeDB");
            txbx_name.Text = stickers[0].Product_Name.ToString();
            txbx_price.Text = stickers[0].Product_Price.ToString();
            txbx_model.Text = stickers[0].Model.ToString();
            txbx_color.Text = stickers[0].Color.ToString();
            txbx_sizes.Text = stickers[0].Size.ToString();
            txbx_cards_count.Text = stickers[0].Cards_Count.ToString();
            txbx_inner_storage.Text = stickers[0].Inner_Storage.ToString();
            txbx_ram.Text = stickers[0].Ram.ToString();
            txbx_back_camera.Text = stickers[0].Back_Camera.ToString();
            txbx_front_camera.Text = stickers[0].Front_Camera.ToString();
            txbx_battery_volume.Text = stickers[0].Battery_Volume.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // save edited data and send it to database //
            usingDB = new UsingDB();
            usingDB.ConnectDB("FromAeDB");
            usingDB.InsertEditProData(txbx_name.Text, txbx_price.Text);
            usingDB.InsertEditSpeData(txbx_model.Text, txbx_color.Text, txbx_sizes.Text, txbx_cards_count.Text, txbx_inner_storage.Text, txbx_ram.Text, 
                txbx_back_camera.Text, txbx_front_camera.Text, txbx_battery_volume.Text);

            usingDB.DisposeSeans();
            MessageBox.Show("Məlumat yadda saxlanıldı");

            AdminsStickers adminsStickers = new AdminsStickers();
            adminsStickers.Visible = false;
            adminsStickers.Show();
            //adminsStickers.AdminsStickers_Load(sender, e);
            this.Visible = false;

        }

        private void EditStickerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
