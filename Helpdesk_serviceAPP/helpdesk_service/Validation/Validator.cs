using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using helpdesk_service.Models;

namespace helpdesk_service.Validation
{
    abstract class Validator
    {
        private string[] errors = new string[10];
        private int counter = 0;

        internal void AddError(string errorMsg, bool check)
        {
            errors[counter] = errorMsg;
            counter++;
            check = false;
        }

        public abstract bool CheckInputs(UserModel user);
       
        public string[] GetAllErrorArray()
        {
            Array.Resize(ref errors, counter);
            return errors;
        }
    }

    class SimpleUserValidator : Validator
    {
        public override bool CheckInputs(UserModel user)
        {
            bool check = true;
            if (String.IsNullOrEmpty(user.Name))
            {
                AddError("Xanalar boş ola bilməz", check);
            }
            if (String.IsNullOrEmpty(user.Surname))
            {
                AddError("Xanalar boş ola bilməz", check);
            }
            if (!user.Email.Contains("@"))
            {
                AddError("Elektron poçt ünvanız yanlışdır", check);
            }
            if (String.IsNullOrEmpty(user.Password) && user.Password.Length < 7)
            {
                AddError("Şifrənin uzunluğu minimum 6 simvol olmalıdır", check);
            }
            if (user.Password != user.Confirm_Password)
            {
                AddError("Şifrələr bir biri ilə eyni olmalıdır", check);
            }
            return check;
        }
    }

    class CardUserValidator : Validator
    {
        public override bool CheckInputs(UserModel user)
        {
            bool check = true;
            if (!user.Email.Contains("@"))
            {
                AddError("Elektron poçt ünvanız yanlışdır", check);
            }
            if (String.IsNullOrEmpty(user.Password) && user.Password.Length < 7)
            {
                AddError("Şifrənin uzunluğu minimum 6 simvol olmalıdır", check);
            }
            if (user.Password != user.Confirm_Password)
            {
                AddError("Şifrələr bir biri ilə eyni olmalıdır", check);
            }
            if (String.IsNullOrEmpty(user.Card_Number))
            {
                AddError("Xanalar boş ola bilməz", check);
            }
            return check;
        }
    }
}
