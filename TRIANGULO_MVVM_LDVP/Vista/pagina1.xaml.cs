using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRIANGULO_MVVM_LDVP.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TRIANGULO_MVVM_LDVP.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pagina1 : ContentPage
    {
        public pagina1()
        {
            InitializeComponent();
            BindingContext = new VMpagina1(Navigation);
        }
    }
}