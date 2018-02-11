using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsletter.Newsletter.Sender
{
    public abstract class AbstractSender
    {
        protected int _sendMessageCout = 0;

        public AbstractSender() { }

        virtual public void Send(string addressEmail, string message) {

        }

        public int GetSenderCount()
        {
            return _sendMessageCout;
        }

    }
}
