using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using helpdesk_service.Gui_Databases;
using helpdesk_service.Models;

namespace helpdesk_service
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        public string BankCard { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            // checking txbx values if card details contain in database payment will be successfull //
            if(BankCards.Card_Number == txbx_bank_card_number.Text && BankCards.Card_Expiry_Date == txbx_expiry_date.Text 
              && BankCards.Card_Cvc == txbx_cvc_number.Text)
            {
                // adding amount to balance //
                ArrayList cardData = CardDetailsDB.GetAllCardData();
                int cardBalance = Convert.ToInt32(BankCards.Card_Balance);
                int txbxAmount = Convert.ToInt32(txbx_payment_amount.Text);
                if (txbxAmount <= cardBalance)
                {
                    MessageBox.Show("Ödəniş uğurlu yerinə yetirildi" + "\n" + "Zəhmət olmasa balansı yoxluyun");
                    foreach (CardModel card in cardData)
                    {
                        card.CardPrice = txbx_payment_amount.Text + " AZN";
                    }
                    // returnig to helpdesk service form //
                    HelpdeskServiceForm service_form = new HelpdeskServiceForm();
                    service_form.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Balansınızda kifayyət qədər məbləğ yoxdur");
                }
                
            }
            else
            {
                MessageBox.Show("Kartın məlumatları düzgün deyil");
            }
           
        }
    }
}
