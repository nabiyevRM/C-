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

namespace helpdesk_service
{
    public partial class GenerateCardsForSale : Form
    {
        public GenerateCardsForSale()
        {
            InitializeComponent();
        }

        private void btn_create_card_Click(object sender, EventArgs e)
        {
            //generating card number//
            Random R = new Random();
            string num = ((long)R.Next(0, 10000) * (long)R.Next(0, 10000) * (long)R.Next(0, 10000)).ToString().PadLeft(12,'0');
            txbx_generated_card_number.Text = num;
            
            //chooseng random price from array//
            int[] prices = { 15, 25, 50 };
            Random randomPrice = new Random();
            int price = randomPrice.Next(prices.Length);
            txbx_card_price.Text = prices[price].ToString()+" AZN";
        }

        private void btn_saleCard_Click(object sender, EventArgs e)
        {
            //writeing card details to cardModel//
            CardModel cardModel = new CardModel();
            cardModel.CardNumber = txbx_generated_card_number.Text;
            cardModel.CardPrice = txbx_card_price.Text;
            cardModel.CardCreate = DateTime.Now;
            cardModel.CardExpiryDate = DateTime.Now.AddMonths(3);

            //adding card to card database//
            CardDetailsDB.AddingCard(cardModel);
            MessageBox.Show("Kart satışa çıxarıldı" +"\n" + "Istifadəçi artıq kart ilə qeydiyyatdan keçə bilər" + "\n" +"Kart nömrəsi: " +txbx_generated_card_number.Text);

            //pass to user registration form//
            UserRegistrationForm user_reg_form = new UserRegistrationForm();
            user_reg_form.Show();
            Visible = false;
        }
    }
}
