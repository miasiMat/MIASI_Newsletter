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
    public class ClientTests
    {
        [TestMethod()]
        public void GetEmailTest()
        {
            Client client = new Client("Jan", "Nowak", "00000000000");
            client.SetEmail("Jan@Nowak.pl");
            Assert.AreEqual("Jan@Nowak.pl", client.GetEmail());
        }

        [TestMethod()]
        public void GetPeriodTest()
        {
            Client client = new Client("Jan", "Nowak", "00000000000");
            client.SetPeriod(3);
            Assert.AreEqual(3, client.GetPeriod());
        }

        [TestMethod()]
        public void SetMessageTypeTest1()
        {
            Client client = new Client("Jan", "Nowak", "00000000000");
            client.AddClientTag("sport");
            client.SetEmail("Jan@Nowak.pl");
            client.SetPeriod(1);
            client.SetMessageType(new Message.ConcreteMessage01());

            List<string> tagList = new List<string>();
            tagList.Add("sport");
            News news = new News("Jan Kowalski", "Wygrana", "Polska Mistrzem Świata!", tagList);

            client.NewNews(news);
            client.CreateMessage();

            Assert.AreEqual("Wiadomości Wersja 01:\r", client.GetMessage().Split('\n').ElementAt(0));
        }

        [TestMethod()]
        public void SetMessageTypeTest2()
        {
            Client client = new Client("Jan", "Nowak", "00000000000");
            client.AddClientTag("sport");
            client.SetEmail("Jan@Nowak.pl");
            client.SetPeriod(1);
            client.SetMessageType(new Message.ConcreteMessage02());

            List<string> tagList = new List<string>();
            tagList.Add("sport");
            News news = new News("Jan Kowalski", "Wygrana", "Polska Mistrzem Świata!", tagList);

            client.NewNews(news);
            client.CreateMessage();

            Assert.AreEqual("Wiadomości Wersja 02:\r", client.GetMessage().Split('\n').ElementAt(0));
        }

        [TestMethod()]
        public void ClearNewsTest()
        {
            Client client = new Client("Jan", "Nowak", "00000000000");
            client.AddClientTag("sport");
            client.SetEmail("Jan@Nowak.pl");
            client.SetPeriod(1);
            client.SetMessageType(new Message.ConcreteMessage01());

            List<string> tagList = new List<string>();
            tagList.Add("sport");
            News news = new News("Jan Kowalski", "Wygrana", "Polska Mistrzem Świata!", tagList);

            client.NewNews(news);
            client.CreateMessage();

            client.ClearNews();

            client.CreateMessage();
            Assert.AreEqual("Wiadomości Wersja 01:\r\n", client.GetMessage());
        }

        [TestMethod()]
        public void AddClientTagTest()
        {
            Client client = new Client("Jan", "Nowak", "00000000000");
            client.SetEmail("Jan@Nowak.pl");
            client.SetPeriod(1);
            client.SetMessageType(new Message.ConcreteMessage01());

            List<string> tagList = new List<string>();
            tagList.Add("sport");
            News news = new News("Jan Kowalski", "Wygrana", "Polska Mistrzem Świata!", tagList);

            client.NewNews(news);
            client.CreateMessage();
            Assert.AreEqual("Wiadomości Wersja 01:\r\n", client.GetMessage());

            client.AddClientTag("sport");
            client.NewNews(news);
            client.CreateMessage();
            Assert.AreEqual("Wiadomości Wersja 01:\r\n" + DateTime.Now.ToString() + "\r\nWygrana\r\nPolska Mistrzem Świata!\r\nsport,\r\n", client.GetMessage());
        }
    }
}