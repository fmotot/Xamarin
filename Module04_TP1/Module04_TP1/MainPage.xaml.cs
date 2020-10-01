using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Module04_TP1.Models;
using Module04_TP1.Services;

namespace Module04_TP1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ITwitterService twitterService;
        public MainPage()
        {
            InitializeComponent();
            //this.twitterService = new TwitterService();
        }

        protected override void OnAppearing()
        {
            Task.Factory.StartNew(() =>
            {
                Task.Delay(TimeSpan.FromSeconds(1.5)).Wait();
                Xamarin.Essentials.MainThread.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PushAsync(new ConnectionPage());
                });
            });
        }


        //public void DisplayTweets()
        //{
        //    List<Tweet> tweets = twitterService.GetTweets("yololo");

        //    foreach (var tweet in tweets)
        //    {
        //        this.TweetsDisplay.Children.Add(new DisplayTweet(tweet));
        //    }
        //    TweetsDisplay.IsVisible = true;
        //}
    }
}
