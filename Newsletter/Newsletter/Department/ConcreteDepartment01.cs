
using System;
using System.Collections.Generic;

namespace Newsletter.Newsletter.Department
{
    public class ConcreteDepartment01 : AbstractDepartment
    {
        public ConcreteDepartment01(Office office) : base(office)
        {

        }

        override public void NewNews(string author, string title, string message, List<string> tagList)
        {
            News news = new News(author, title, message, tagList);
            _office.AddNewNews(news);
        }
    }
}
