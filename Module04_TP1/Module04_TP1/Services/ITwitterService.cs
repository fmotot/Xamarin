using Module04_TP1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module04_TP1.Services
{
    interface ITwitterService
    {
        bool Authenticate(String login, String password);

        List<Tweet> GetTweets(String str);
    }
}
