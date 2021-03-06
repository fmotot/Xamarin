﻿using Module04_TP1.Services;
using System;
using System.Diagnostics;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04_TP1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Connection : ContentView
    {
        private const string LOGIN_ERROR = "Identifiant trop court (3 caractères minimum)";
        private const string PASSWORD_ERROR = "Mot de passe trop court (6 caractères minimum)";
        private const string INCORRECT_LOGIN_PASSWORD = "Identifiant ou mot de passe incorrect";
        private const string NO_INTERNET = "Pas de connexion internet";
        private ITwitterService ts;

        public Button Btn { get; set; }
        public Connection()
        {
            ts = new TwitterService();
            InitializeComponent();
            this.Btn = ConnectionBtn;
            this.ConnectionBtn.Clicked += ConnectionBtn_Clicked;
        }

        private void ConnectionBtn_Clicked(object sender, EventArgs e)
        {
            var connection = Connectivity.NetworkAccess;

            if (connection == NetworkAccess.Internet)
            {

                bool testLogin = true;
                bool testPassword = true;
                StringBuilder sb = new StringBuilder();

                if (this.IdEntry.Text == null || this.IdEntry.Text.ToString().Length < 3)
                {
                    testLogin = false;
                    sb.Append(LOGIN_ERROR);
                }
                if (this.PasswordEntry.Text == null || this.PasswordEntry.Text.ToString().Length < 6)
                {
                    testPassword = false;
                    if (!testLogin)
                    {
                        sb.Append("\n");
                    }
                    sb.Append(PASSWORD_ERROR);
                }

                if (testLogin && testPassword)
                {
                    Debug.WriteLine("Boutoonnn !!!!!!!!!!!");
                    Debug.WriteLine("Login : " + this.IdEntry.Text);
                    Debug.WriteLine("Password : " + this.PasswordEntry.Text);
                    Debug.WriteLine("Se souvenir : " + this.RememberMeSwitch.IsToggled.ToString());

                    if (ts.Authenticate(this.IdEntry.Text, this.PasswordEntry.Text))
                    {
                        this.ErrorDisplay.IsVisible = false;
                        Navigation.PushAsync(new TweetsPage());
                    }
                    else
                    {
                        this.ErrorDisplay.Text = INCORRECT_LOGIN_PASSWORD;
                        this.ErrorDisplay.IsVisible = true;
                    }
                }
                else
                {
                    this.ErrorDisplay.Text = sb.ToString();
                    this.ErrorDisplay.IsVisible = true;
                }
            }
            else
            {
                this.ErrorDisplay.Text = NO_INTERNET;
                this.ErrorDisplay.IsVisible = true;
            }
        }
    }
}