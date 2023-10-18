using System;
using TRIANGULO_MVVM_LDVP.Vista;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TRIANGULO_MVVM_LDVP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new pagina1();
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
