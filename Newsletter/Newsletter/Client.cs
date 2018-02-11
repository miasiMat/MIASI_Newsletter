using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsletter.Newsletter
{
    public class Client
    {
        string _firstName;
        string _secondName;
        string _pesel;
        string _email;
        int _period;

        Message.AbstractMessage _message;

        private List<News> _newsList;
        private List<string> _tagList;

        public Client(string firstName, string secondName, string pesel)
        {
            _firstName = firstName;
            _secondName = secondName;
            _pesel = pesel;
            _tagList = new List<string>();
            _newsList = new List<News>();
        }

        public void SetEmail(string email)
        {
            _email = email;
        }

        public string GetEmail()
        {
            return _email;
        }

        public void SetPeriod(int period)
        {
            _period = period;
        }

        public int GetPeriod()
        {
            return _period;
        }


        public void SetMessageType(Message.AbstractMessage message)
        {
            _message = message;
        }

        public string GetMessage()
        {
            return _message.getMessage();
        }

        public void AddClientTag(string tag)
        {
            if(!_tagList.Contains(tag))
                _tagList.Add(tag);
        }

        public void RemoveClientTag(string tag)
        {
            _tagList.Remove(tag);
        }


        public void NewNews(News news)
        {
            List<string> newsTagList = news.GetTagList();
            foreach (string messageTag in newsTagList)
            {
                foreach (string clientTag in _tagList)
                {
                    if (messageTag == clientTag)
                    {
                        _newsList.Add(news);
                        return;
                    }
                }
            }
        }

        public void CreateMessage()
        {
            _message.addNews(_newsList);
        }

        public void ClearNews()
        {
            _message.Clear();
            _newsList.Clear();
        }
    }
}
