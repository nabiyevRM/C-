using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AistGroup_IT_Company.Models;

namespace AistGroup_IT_Company.Gui
{
    class Validator
    {
        //register input errors container field//
        private string[] errors = new string[10];
        private int counter = 0;

        //checking cv and its error container field//
        private string[] errors_cv = new string[10];
        private int counter_cv = 0;

        //adding errors method to register content// 
        private void AddError(string errorMsg,bool check)
        {
            errors[counter] = errorMsg;
            counter++;
            check = false;
        }
        //checking register inputs method//
        public bool CheckInputs(User user)
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
            if(user.Password != user.Confirm_Password)
            {
                AddError("Şifrələr bir biri ilə eyni olmalıdır", check);
            }
            return check;
        }

        //adding errors method to cv content// 
        private void CV_Validate(string errorMsg, bool check)
        {
            errors_cv[counter_cv] = errorMsg;
            counter_cv++;
            check = false;
        }

        //checking cv form method//
        public bool cvChecking(CV_Format cv_format)
        {
            bool check = true;
            if (string.IsNullOrEmpty(cv_format.CV_User_Name))
            {
                CV_Validate("x", check);
            }
            if (string.IsNullOrEmpty(cv_format.CV_User_Surname))
            {
                CV_Validate("x", check);
            }
            if (string.IsNullOrEmpty(cv_format.CV_User_Email))
            {
                CV_Validate("x", check);
            }
            if (string.IsNullOrEmpty(cv_format.CV_User_Skills))
            {
                CV_Validate("x", check);
            }
            if (string.IsNullOrEmpty(cv_format.CV_User_Salary))
            {
                CV_Validate("x", check);
            }
            return check;
        }

        //get all erros from register inputs if erros doesn't contain accepts user data//
        public string[] GetAllErrorArray()
        {
            Array.Resize(ref errors, counter);
            return errors;
        }

        //get all erros from cv form if erros doesn't contain accepts user cv//
        public string[] GetAllCVerrorsArray()
        {
            Array.Resize(ref errors_cv, counter_cv);
            return errors_cv;
        }
    }
}
