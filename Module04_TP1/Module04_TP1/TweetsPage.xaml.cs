using Module04_TP1.Models;
using Module04_TP1.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04_TP1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetsPage : ContentPage
    {
        ITwitterService ts;
        public TweetsPage()
        {
            InitializeComponent();

            ts = new TwitterService();
            ObservableCollection<Tweet> tweets = new ObservableCollection<Tweet>();
            ts.GetTweets("yololo").ForEach( t => tweets.Add(t));

            tweets.Add(new Tweet
            {
                Id = 1,
                Login = "loth@kaamelott.fr",
                Pseudo = "Loth d'Orcanie",
                CreationDate = new DateTime(427, 1, 12, 16, 35, 42),
                Text = "Tempora mori, tempora mundis recorda . Voilà, eh ben ça par exemple, ça ne veut absolument rien dire, mais l’effet reste le même…"
            });

            this.MaListe.ItemsSource = tweets;
        }
    }
}