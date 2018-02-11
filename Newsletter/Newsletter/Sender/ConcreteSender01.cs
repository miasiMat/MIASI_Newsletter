using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsletter.Newsletter.Sender
{
    public class ConcreteSender01 : AbstractSender
    {
        public ConcreteSender01() : base()
        {

        }

        override public void Send(string addressEmail, string message)
        {
            _sendMessageCout++;
            Console.WriteLine("Send Email Message To: " + addressEmail);
        }

    }
}
