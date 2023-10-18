using MVVM_LDVP6.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace TRIANGULO_MVVM_LDVP.VistaModelo
{
    internal class VMpagina1 : BaseViewModel
    {
        #region VARIABLES
        string _baseT;
        string _altura;
        string _lado1;
        string _lado2;
        string _resultado;
        string _area;
        #endregion
        #region CONSTRUCTOR
        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string BaseT
        {
            get { return _baseT; }
            set { SetValue(ref _baseT, value); }
        }
        public string Altura
        {
            get { return _altura; }
            set { SetValue(ref _altura, value); }
        }
        public string Lado1
        {
            get { return _lado1; }
            set { SetValue(ref _lado1, value); }
        }
        public string Lado2
        {
            get { return _lado2; }
            set { SetValue(ref _lado2, value); }
        }
        public string Resultado
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }
        public string Area
        {
            get { return _area; }
            set { SetValue(ref _area, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void CalcularTriangulo()
        {
            double baseT = Convert.ToDouble(BaseT);
            double alturaT = Convert.ToDouble(BaseT);
            double lado1 = Convert.ToDouble(BaseT);
            double lado2 = Convert.ToDouble(Lado2);
            string resultado = Convert.ToString(baseT);
            double area = Convert.ToDouble(Area);

            area = (baseT * alturaT / 2);
            Area = area.ToString();

            if (baseT <= 0 || lado1 <= 0 || lado2 <= 0)
            {
                resultado = "No es un triangulo";
            }
            else if (lado1 == baseT && lado2 == baseT && lado1 == lado2)
            {

                resultado = "Es un triangulo equilatero";
            }
            else if (lado1 != baseT && lado2 != baseT && lado1 != lado2)
            {

                resultado = "Es un triangulo escaleno";
            }

            else
            {
                resultado = "Es un triangulo isoceles";
            }


        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand CalcularCommand => new Command(CalcularTriangulo);
        #endregion
    }
}


