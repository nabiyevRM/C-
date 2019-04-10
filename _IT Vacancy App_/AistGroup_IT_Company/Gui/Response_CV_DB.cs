using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AistGroup_IT_Company.Models;

namespace AistGroup_IT_Company.Gui
{
    class Response_CV_DB
    {
        private static ArrayList Response_CV_Data = new ArrayList();
       

        public static ArrayList AddCVAcceptReason(Response_CV_Class response_cv)
        {
            Response_CV_Data.Add(response_cv);
            return Response_CV_Data;
        }

        public static ArrayList GetAllData()
        {
            return Response_CV_Data;
        }
    }
}
