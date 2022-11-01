using System;
using System.Globalization;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAgendaSoccer
{
    public partial class App : Application
    {
        public App()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            InitializeComponent();

            MainPage = new NavigationPage(new View.Login());

            /*if (Properties.ContainsKey("usuario_logado"))
                MainPage = new NavigationPage(new View.Home());
            else
                MainPage = new NavigationPage(new View.Login());*/
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
