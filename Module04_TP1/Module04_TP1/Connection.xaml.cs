using Module04_TP1.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Button Btn { get; set; }
        public Connection()
        {
            InitializeComponent();
            this.Btn = ConnectionBtn;
            this.ConnectionBtn.Clicked += ConnectionBtn_Clicked;
        }

        private void ConnectionBtn_Clicked(object sender, EventArgs e)
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

                TwitterService ts = new TwitterService();
                if (ts.Authenticate(this.IdEntry.Text, this.PasswordEntry.Text))
                {
                    this.IsVisible = false;
                    this.ErrorDisplay.IsVisible = false;
                    if ((this.Parent.Parent as MainPage) != null)
                    {
                        (this.Parent.Parent as MainPage).DisplayTweets();
                    }
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
    }
}