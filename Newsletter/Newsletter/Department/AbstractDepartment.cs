using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsletter.Newsletter.Department
{
    public abstract class AbstractDepartment
    {
        protected Office _office;
        public AbstractDepartment(Office office)
        {
            _office = office;
        }

        public virtual void NewNews(string author, string title, string message, List<string> tagList)
        {

        }
    }
}
