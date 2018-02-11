using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsletter.Newsletter.Message
{
    public class ConcreteMessage02 : AbstractMessage
    {
        public ConcreteMessage02() : base()
        {

        }

        override public void addNews(List<News> newsList)
        {
            _message = String.Empty;
            _message += "Wiadomości Wersja 02:" + "\r\n";
            foreach (News news in newsList)
            {
                _message += news.GetDateTime().ToString() + "\r\n";
                _message += news.GetTitle() + "\r\n";
                _message += news.GetMessage() + "\r\n";
                foreach (string tag in news.GetTagList())
                {
                    _message += tag + ",";
                }
                _message += "\r\n";
            }
        }
    }
}
