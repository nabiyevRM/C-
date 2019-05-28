using Admin_Form;
using FromAe_App.Core;
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
    public partial class AdminsStickers : Form
    {
        public AdminsStickers()
        {
            InitializeComponent();
        }

        public void AdminsStickers_Load(object sender, EventArgs e)
        {
            UsingDB usingDB = new UsingDB();
            List<StickerModel> stickers = usingDB.GetStickers("FromAeDB");
            dataGridView1.DataSource = stickers;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            EditDataId.Id = id;
            EditStickerForm edit = new EditStickerForm();
            edit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 admin_form = new Form1();
            admin_form.Show();
            this.Visible = false;
        }

        private void AdminsStickers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
