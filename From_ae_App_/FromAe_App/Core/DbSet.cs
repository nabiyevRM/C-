using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Form.Core
{
    class DbSet<T>
    {
        private List<T> container;

        public DbSet()
        {
            container = new List<T>();
        }

        public void Add(T model)
        {
            container.Add(model);
        }

        public List<T> GetAllData()
        {
            return container;
        }
    }
}
