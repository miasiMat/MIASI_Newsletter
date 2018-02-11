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
    public class NewsTests
    {
        [TestMethod()]
        public void GetTagListTest()
        {
            List<string> tagList = new List<string>();
            tagList.Add("sport");
            tagList.Add("polska");
            News news = new News("Jan Kowalski", "Wygrana", "Polska Mistrzem Świata!", tagList);

            Assert.AreEqual("sport", news.GetTagList().ElementAt(0));
            Assert.AreEqual("polska", news.GetTagList().ElementAt(1));
        }

        [TestMethod()]
        public void getAuthorTest()
        {
            List<string> tagList = new List<string>();
            tagList.Add("sport");
            tagList.Add("polska");
            News news = new News("Jan Kowalski", "Wygrana", "Polska Mistrzem Świata!", tagList);

            Assert.AreEqual("Jan Kowalski", news.GetAuthor());
        }

        [TestMethod()]
        public void getTitleTest()
        {
            List<string> tagList = new List<string>();
            tagList.Add("sport");
            tagList.Add("polska");
            News news = new News("Jan Kowalski", "Wygrana", "Polska Mistrzem Świata!", tagList);

            Assert.AreEqual("Wygrana", news.GetTitle());
        }

        [TestMethod()]
        public void GetDateTimeTest()
        {
            List<string> tagList = new List<string>();
            tagList.Add("sport");
            tagList.Add("polska");
            News news = new News("Jan Kowalski", "Wygrana", "Polska Mistrzem Świata!", tagList);
            Assert.IsTrue(DateTime.Now.CompareTo(news.GetDateTime()) == 0);
        }

        [TestMethod()]
        public void getMessageTest()
        {
            List<string> tagList = new List<string>();
            tagList.Add("sport");
            tagList.Add("polska");
            News news = new News("Jan Kowalski", "Wygrana", "Polska Mistrzem Świata!", tagList);
            Assert.AreEqual("Polska Mistrzem Świata!", news.GetMessage());
        }
    }
}