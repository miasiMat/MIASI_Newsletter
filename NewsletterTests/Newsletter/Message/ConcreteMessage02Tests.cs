using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newsletter.Newsletter.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsletter.Newsletter.Message.Tests
{
    [TestClass()]
    public class ConcreteMessage02Tests
    {
        [TestMethod()]
        public void addNewsTest()
        {
            ConcreteMessage02 concreteMessage = new ConcreteMessage02();

            List<string> tagList = new List<string>();
            tagList.Add("sport");
            News news1 = new News("Jan Kowalski", "Wygrana", "Polska Mistrzem Świata!", tagList);

            List<string> tagList2 = new List<string>();
            tagList2.Add("polska");
            News news2 = new News("Jan Nowak", "Nowa droga", "W 2019 zostanie otworzona nowa droga S5", tagList2);

            List<News> newsList = new List<News>();
            newsList.Add(news1);
            newsList.Add(news2);

            concreteMessage.addNews(newsList);

            Assert.AreEqual("Wiadomości Wersja 02:\r\n" + DateTime.Now.ToString() + "\r\nWygrana\r\nPolska Mistrzem Świata!\r\nsport,\r\n" + DateTime.Now.ToString() + "\r\nNowa droga\r\nW 2019 zostanie otworzona nowa droga S5\r\npolska,\r\n", concreteMessage.getMessage());
        }
    }
}