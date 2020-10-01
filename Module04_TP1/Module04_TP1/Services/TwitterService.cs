using System;
using System.Collections.Generic;
using System.Text;
using Module04_TP1.Models;
using Module04_TP1.Services;

namespace Module04_TP1.Services
{
    public class TwitterService : ITwitterService
    {
        private const string LOGIN = "fred";
        private const string PASSWORD = "123456";

        public bool Authenticate(string login, string password)
        {
            return login.Equals(LOGIN) && password.Equals(PASSWORD);
        }

        public List<Tweet> GetTweets(string str)
        {
            List<Tweet> tweets = new List<Tweet>();

            tweets.Add(
                new Tweet
                {
                    Id = 1,
                    Login = "loth@kaamelott.fr",
                    Pseudo = "Loth d'Orcanie",
                    CreationDate = new DateTime(427, 1, 12, 16, 35, 42),
                    Text = "Tempora mori, tempora mundis recorda . Voilà, eh ben ça par exemple, ça ne veut absolument rien dire, mais l’effet reste le même…"
                }
            );

            tweets.Add(
                new Tweet
                {
                    Id = 2,
                    Login = "loth@kaamelott.fr",
                    Pseudo = "Loth",
                    CreationDate = new DateTime(427, 1, 12, 19, 35, 42),
                    Text = "Ave Cesar, rosae rosam, et spiritus rex ! Ah non, parce que là, j’en ai marre !"
                }
            );

            tweets.Add(
                new Tweet
                {
                    Id = 3,
                    Login = "loth@kaamelott.fr",
                    Pseudo = "Loth",
                    CreationDate = new DateTime(416, 1, 12, 16, 35, 42),
                    Text = "Sanctis recorda, sanctis deus rex"
                }
            );

            tweets.Add(
                new Tweet
                {
                    Id = 4,
                    Login = "gal@kaamelott.fr",
                    Pseudo = "Galessin",
                    CreationDate = new DateTime(416, 1, 12, 16, 36, 42),
                    Text = "Ce qui veut dire ?"
                }
            );

            tweets.Add(
                new Tweet
                {
                    Id = 5,
                    Login = "loth@kaamelott.fr",
                    Pseudo = "Loth",
                    CreationDate = new DateTime(427, 1, 12, 16, 37, 42),
                    Text = "Absolument rien. Pourquoi ?"
                }
            );
            
            tweets.Add(
                new Tweet
                {
                    Id = 1,
                    Login = "loth@kaamelott.fr",
                    Pseudo = "Loth",
                    CreationDate = new DateTime(449, 2, 12, 9, 37, 42),
                    Text = "Victoriae mundis et mundis lacrima . Bon, ça ne veut absolument rien dire, mais je trouve que c’est assez dans le ton. "
                }
            );



            return tweets;
        }
    }
}
