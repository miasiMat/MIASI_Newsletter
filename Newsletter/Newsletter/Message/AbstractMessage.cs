using System;
using System.Collections.Generic;

namespace Newsletter.Newsletter.Message
{
    public abstract class AbstractMessage
    {

        protected string _message;

        public AbstractMessage()
        {
            _message = String.Empty;
        }

        virtual public void addNews(List<News> newsList)
        {
        }

        public string getMessage()
        {
            return _message;
        }

        public void Clear()
        {
            _message = String.Empty;
        }
    }
}
