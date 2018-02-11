using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newsletter.Newsletter.Sender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsletter.Newsletter.Sender.Tests
{
    [TestClass()]
    public class ConcreteSender02Tests
    {
        [TestMethod()]
        public void SendTest()
        {
            ConcreteSender02 concreteSender = new ConcreteSender02();
            Assert.AreEqual(0, concreteSender.GetSenderCount());
            concreteSender.Send("mail", "message");
            Assert.AreEqual(1, concreteSender.GetSenderCount());
        }
    }
}