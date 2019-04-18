using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpdesk_service.Models
{
    static class BankCards
    {
        private static string card_number = "123456789011";
        private static string card_cvc = "123";
        private static string card_expiry_date ="03/21";
        private static string card_balance = "100";

        public static string Card_Number { get { return card_number; } }
        public static string Card_Cvc { get { return card_cvc; } }
        public static string Card_Expiry_Date { get { return card_expiry_date; } }
        public static string Card_Balance { get { return card_balance; } }
    }
}
