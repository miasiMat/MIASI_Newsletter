using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newsletter.Newsletter.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsletter.Newsletter.Department.Tests
{
    [TestClass()]
    public class ConcreteDepartment02Tests
    {
        [TestMethod()]
        public void NewNewsTest()
        {
            Office office = new Office(new Sender.ConcreteSender01());
            ConcreteDepartment02 concreteDepartment = new ConcreteDepartment02(office);
            List<string> tagList = new List<string>();
            tagList.Add("sport");
            concreteDepartment.NewNews("Jan Kowalski", "Wygrana", "Polska Mistrzem Świata!", tagList);

            News curretnNews = office.getNewsList().ElementAt(0);

            Assert.AreEqual(curretnNews.GetAuthor(), "Jan Kowalski");
            Assert.AreEqual(curretnNews.GetTitle(), "Wygrana");
            Assert.AreEqual(curretnNews.GetMessage(), "Polska Mistrzem Świata!");
            Assert.AreEqual(curretnNews.GetTagList().ElementAt(0), "sport");
        }
    }
}