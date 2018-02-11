
using System;
using System.Collections.Generic;
using System.Timers;

namespace Newsletter.Newsletter
{
    public class Office
    {
        List<Newsletter.Client> _clientsList;
        List<string> _availableTag;
        int _period = 0;
        Sender.AbstractSender _sender;
        List<News> _newsList;

        public Office(Sender.AbstractSender sender) {
            _clientsList = new List<Newsletter.Client>();
            _availableTag = new List<string>();
            _newsList = new List<News>();
            _sender = sender;

            Timer timer = new Timer(1000);
            timer.Elapsed += OnTimedEvent;
            timer.Start();
        }

        public void AddClient(Newsletter.Client client)
        {
            _clientsList.Add(client);
        }

        public void AddNewNews(Newsletter.News news)
        {
            _newsList.Add(news);
            foreach (string tag in news.GetTagList())
            {
                if(!_availableTag.Contains(tag))
                    _availableTag.Add(tag);
            }

            foreach (Newsletter.Client client in _clientsList)
            {
                client.NewNews(news);
            }
        }

        public List<News> getNewsList()
        {
            return _newsList;
        }

        public List<string> getAvailableTagList()
        {
            return _availableTag;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            CheckPeriod();
        }

        public void CheckPeriod()
        {
            _period++;
            foreach (Client client in _clientsList)
            {
                if((client.GetPeriod() % _period) == 0)
                {
                    client.CreateMessage();
                    string message = client.GetMessage();
                    _sender.Send(client.GetEmail(), message);
                }
            }
        }

    }
}
