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
        public Button Btn { get; set; }
        public Connection()
        {
            InitializeComponent();
            this.Btn = ConnectionBtn;
            this.ConnectionBtn.Clicked += ConnectionBtn_Clicked;
        }

        private void ConnectionBtn_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Boutoonnn !!!!!!!!!!!");
            if (this.IdEntry.Text == null || this.PasswordEntry.Text == null)
            {
                this.ErrorDisplay.Text = "Merci de compléter les informations de connexion";
                this.ErrorDisplay.IsVisible = true;
            }
            else
            {
                Debug.WriteLine(this.IdEntry.Text.ToString().Length);

                if (this.IdEntry.Text.ToString().Length < 3)
                {
                    this.ErrorDisplay.Text = "Identifiant trop court (3 caractères minimum)";
                    this.ErrorDisplay.IsVisible = true;
                }
                else if (this.PasswordEntry.Text.ToString().Length < 6)
                {
                    this.ErrorDisplay.Text = "Mot de passe trop court (6 caractères minimum)";
                    this.ErrorDisplay.IsVisible = true;
                }
                else
                {
                    Debug.WriteLine("Login : " + this.IdEntry.Text);
                    Debug.WriteLine("Password : " + this.PasswordEntry.Text);
                    Debug.WriteLine("Se souvenir : " + this.RememberMeSwitch.IsToggled.ToString());
                    this.IsVisible = false;
                    this.ErrorDisplay.IsVisible = false;
                    if ((this.Parent.Parent as MainPage) != null)
                    {
                        (this.Parent.Parent as MainPage).DisplayTweets();
                    }
                }
            }
        }
    }
}