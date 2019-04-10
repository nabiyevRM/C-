using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AistGroup_IT_Company.Models
{
    class CV_Format
    {
        private string cv_user_name;
        private string cv_user_surname;
        private string cv_user_email;
        private string cv_user_skills;
        private string cv_user_salary;

        public string CV_User_Name { get { return cv_user_name; } set { cv_user_name = value; } }
        public string CV_User_Surname { get { return cv_user_surname; } set { cv_user_surname = value; } }
        public string CV_User_Email { get { return cv_user_email; } set { cv_user_email = value; } }
        public string CV_User_Skills { get { return cv_user_skills; } set { cv_user_skills = value; } }
        public string CV_User_Salary { get { return cv_user_salary; } set { cv_user_salary = value; } }
    }
}
