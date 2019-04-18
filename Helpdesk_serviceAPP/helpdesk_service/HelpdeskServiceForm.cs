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
using helpdesk_service.Gui_Databases;
using helpdesk_service.Methods;

namespace helpdesk_service
{
    public partial class HelpdeskServiceForm : Form
    {
        
        public HelpdeskServiceForm()
        {
            InitializeComponent();
        }

        private void HelpdeskServiceForm_Load(object sender, EventArgs e)
        {
            // loads all services from services database //
            ArrayList services = ServicesDB.GetAllServices();
            foreach (Services_Model service in services)
            {
                lbl_helpdesk_serviceName.Text += service.Service_Name + "\n \n" ;
                lbl_helpdesk_servicePrice.Text += service.Service_Price + "\n \n" ;
                lbl_helpdesk_serviceID.Text += service.Service_ID + "--" + "\n \n";
            }

            //get user current money from database//
            ArrayList cards = CardDetailsDB.GetAllCardData();
            foreach (CardModel card in cards)
            {
                user_current_money.Text = card.CardPrice;
            }

            // hide elements when helpdesk service form loads //
            lbl_service_idText.Visible = false;
            txbx_id_service.Visible = false;
            btn_buy_service.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // show payment form //
            PaymentForm payment_form = new PaymentForm();
            payment_form.Show();
            Visible = false;
        }

        private void lbl_helpdesk_serviceName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // show elements when helpdesk service clicks  //
            lbl_service_idText.Visible = true;
            txbx_id_service.Visible = true;
            btn_buy_service.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // get service price from helpdesk service price //
            HelperMethods methods = new HelperMethods();
            int servicePrice = methods.GetServicePrice(txbx_id_service.Text);

            // get current balance  //
            ArrayList currentPrices = CardDetailsDB.GetAllCardData();
            int balance = methods.GetCurrentBalance();

            // operation with balance //
            int changedCurrentPrice = 0;
            if(balance >= servicePrice)
            {
                changedCurrentPrice = balance - servicePrice;
                balance = changedCurrentPrice;

                user_current_money.Text = Convert.ToString(changedCurrentPrice) + " AZN";
                foreach (CardModel prices in currentPrices)
                {
                    prices.CardPrice = user_current_money.Text;
                }
                MessageBox.Show("Xidmət sifariş olundu" + "\n" + "Əməkdaşlar sizinlə əlaqə saxlıyacaq");
                // hide elements when id btn clicks //
                lbl_service_idText.Visible = false;
                txbx_id_service.Visible = false;
                btn_buy_service.Visible = false;
            }
            else
            {
                MessageBox.Show("Balansınızda kifayyət qədər məbləğ yoxdur" +"\n" + "Zəhmət olmasa balansı artırın");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CompanyAdminForm admin_form = new CompanyAdminForm();
            admin_form.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
