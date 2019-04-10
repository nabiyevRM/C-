using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AistGroup_IT_Company.Models
{
    class Response_CV_Class
    {
        private string accept;
        private string reject;

        public string Accept { get { return accept; } set { accept = value; } }
        public string Reject { get { return reject; } set { reject = value; } }
    }
}
