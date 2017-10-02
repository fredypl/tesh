using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tesh
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class formulario : ContentPage
    {
        public formulario()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Bienvenido \n \n", "Datos Personales \n"
           + Nombre.Text + " " + APaterno.Text + " " + AMaterno.Text + " " + Dir.Text + " " + Tel.Text + " " +
           "\n \n Datos Escolares \n"
           + Carrera.Text + " " + Sementre.Text + " " + Matricula.Text + " " +
           "\n \n Datos Sociales \n"
           + Correo.Text + " " + Github.Text + " " +

           "\n \n \n \n \n Datos Ingresados \n", "OK");

            Navigation.PushAsync(new calculadora());

        }
    }
}