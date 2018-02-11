using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsletter.Newsletter.Sender
{
    public class ConcreteSender02 : AbstractSender
    {
        public ConcreteSender02() : base()
        {

        }

        override public void Send(string address, string message)
        {
            _sendMessageCout++;
            Console.WriteLine("Send Message To: " + address);
        }
    }
}
