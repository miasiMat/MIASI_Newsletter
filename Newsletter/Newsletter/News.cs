using System;
using System.Collections.Generic;

namespace Newsletter.Newsletter
{
    public class News
    {
        string _message;
        List<string> _tagList;
        string _author;
        DateTime _dateTime;
        string _title;

        public News(string author, string title, string message, List<string> tagList)
        {
            _author = author;
            _title = title;
            _tagList = tagList;
            _message = message;
            _dateTime = DateTime.Now;
        }

        public List<string> GetTagList()
        {
            return _tagList;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public string GetTitle()
        {
            return _title;
        }

        public DateTime GetDateTime()
        {
            return _dateTime;
        }

        public string GetMessage()
        {
            return _message;
        }

    }
}
