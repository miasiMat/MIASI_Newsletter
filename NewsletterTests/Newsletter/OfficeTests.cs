using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newsletter.Newsletter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsletter.Newsletter.Tests
{
    [TestClass()]
    public class OfficeTests
    {
        [TestMethod()]
        public void getNewsListTest()
        {
            Office office = new Office(new Sender.ConcreteSender01());
            List<string> tagList = new List<string>();
            tagList.Add("sport");
            News news = new News("Jan Kowalski", "Wygrana", "Polska Mistrzem Świata!", tagList);

            office.AddNewNews(news);

            News curretnNews = office.getNewsList().ElementAt(0);

            Assert.AreEqual(curretnNews.GetAuthor(), "Jan Kowalski");
            Assert.AreEqual(curretnNews.GetTitle(), "Wygrana");
            Assert.AreEqual(curretnNews.GetMessage(), "Polska Mistrzem Świata!");
            Assert.AreEqual(curretnNews.GetTagList().ElementAt(0), "sport");
        }

        [TestMethod()]
        public void getAvailableTagListTest()
        {
            Office office = new Office(new Sender.ConcreteSender01());
            List<string> tagList = new List<string>();
            tagList.Add("sport");
            tagList.Add("polska");
            News news = new News("Jan Kowalski", "Wygrana", "Polska Mistrzem Świata!", tagList);

            Assert.AreEqual(office.getAvailableTagList().Count, 0);

            office.AddNewNews(news);

            Assert.AreEqual(office.getAvailableTagList().Count, 2);
        }

        [TestMethod()]
        public void CheckPeriodTest()
        {
            Sender.ConcreteSender01 concreteSender = new Sender.ConcreteSender01();
            Office office = new Office(concreteSender);
            Department.AbstractDepartment department = new Department.ConcreteDepartment01(office);

            Client client = new Client("Jan", "Nowak", "00000000000");
            client.AddClientTag("sport");
            client.SetEmail("Jan@Nowak.pl");
            client.SetPeriod(1);
            client.SetMessageType(new Message.ConcreteMessage01());

            office.AddClient(client);

            List<string> sportTag = new List<string>();
            sportTag.Add("sport");
            department.NewNews("Jan Kowalski", "Mistrzostwo!", "Polska mistrzem świata", sportTag);

            Assert.AreEqual(0, concreteSender.GetSenderCount());

            System.Threading.Thread.Sleep(1500);

            Assert.AreEqual(1, concreteSender.GetSenderCount());
        }
    }
}