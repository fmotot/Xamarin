using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04_TP1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayTweet : ContentView
    {
        public DisplayTweet(Models.Tweet tweet)
        {
            InitializeComponent();

            this.TextZone.Text = tweet.Text;
            this.Pseudo.Text = tweet.Pseudo;
            this.Login.Text = tweet.Login;
            this.Date.Text = tweet.CreationDate.ToString("dd/MM/yyyy H:mm:ss");
        }
    }
}