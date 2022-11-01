using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAgendaSoccer.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        App PropriedadesApp;

        public Login()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            PropriedadesApp = (App)Application.Current;
        }

        private void Button_Clicked_Entrar(object sender, EventArgs e)
        {
            string usuario = txt_email.Text;
            string senha = txt_senha.Text;

            string usuario_correto = "rafael";
            string senha_correta = "1234";

            if (usuario == usuario_correto && senha == senha_correta)
            {
                /*App.Current.Properties.Add("usuario_logado", usuario);
                App.Current.MainPage = new Home();*/

                Navigation.PushAsync(new Home());

            }
            else
                DisplayAlert("Ops!", "Usuário ou senha incorretos.", "OK");
        }

        private void Button_Clicked_Criar(object sender, EventArgs e)
        {

        }
    }
}