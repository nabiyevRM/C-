using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AistGroup_IT_Company.Models;

namespace AistGroup_IT_Company.Gui
{
    static class CV_DB
    {
        private static ArrayList CV_Data = new ArrayList();
        //private static int counter_cv = 0;

        public static ArrayList AddCV(CV_Format cv)
        {
            CV_Data.Add(cv);

            return CV_Data;
        }

        public static ArrayList GetAllData()
        {
            return CV_Data;
        }
    }
}
