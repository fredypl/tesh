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
    public partial class calculadora : ContentPage
    {
        double d1, d2, resul;
        string opera, borrado;
        bool secuencia;

        public calculadora()
        {
            InitializeComponent();
        }

        private void POTENCIA_Clicked(object sender, EventArgs e)
        {
            d1 = double.Parse(caja.Text);
            resul = d1 * d1;
            caja.Text = resul.ToString();
        }

        private void FACTORIAL_Clicked_1(object sender, EventArgs e)
        {
            double factorial = 1;
            resul = double.Parse(caja.Text);

            if (d1 < 0)
            {

            }

            for (int i = 1; i <= resul; i++)
            {
                factorial = i * factorial;
            }
            caja.Text = factorial.ToString();

        }

        private void RAIZ_Clicked_2(object sender, EventArgs e)
        {
            if (d1 > 0)
            {

            }

            else
                d1 = double.Parse(caja.Text);
            resul = Math.Sqrt(d1);
            caja.Text = resul.ToString();
        }

        private void ENTRE_Clicked_3(object sender, EventArgs e)
        {
            opera = "/";
            d1 = double.Parse(caja.Text);
            secuencia = true;
        }

        private void SIETE_Clicked_4(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "7";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "7";
            }
        }

        private void OCHO_Clicked_5(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "8";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "8";
            }
        }

        private void NUEVE_Clicked_6(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "9";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "9";
            }
        }

        private void POR_Clicked_7(object sender, EventArgs e)
        {
            opera = "*";
            d1 = double.Parse(caja.Text);
            secuencia = true;
        }

        private void CUATRO_Clicked_8(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "4";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "4";
            }
        }

        private void CINCO_Clicked_9(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "5";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "5";
            }
        }

        private void SEIS_Clicked_10(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "6";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "6";
            }
        }

        private void MENOS_Clicked_11(object sender, EventArgs e)
        {
            opera = "-";
            d1 = double.Parse(caja.Text);
            secuencia = true;
        }

        private void UNO_Clicked_12(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "1";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "1";
            }
        }

        private void DOS_Clicked_13(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "2";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "2";
            }
        }

        private void TRES_Clicked_14(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                caja.Text = "";
                caja.Text = "3";
                secuencia = false;
            }
            else
            {
                caja.Text = caja.Text + "3";
            }
        }

        private void MAS_Clicked_15(object sender, EventArgs e)
        {
            opera = "+";
            d1 = double.Parse(caja.Text);
            secuencia = true;
        }

        private void MAS_MENOS_Clicked_16(object sender, EventArgs e)
        {
            double d1 = double.Parse(caja.Text);
            d1 *= -1;
            caja.Text = d1.ToString();
        }

        private void CERO_Clicked_17(object sender, EventArgs e)
        {
            if (caja.Text == "0")

            {
                return;

            }
            else
            {
                caja.Text = caja.Text + "0";
            }
        }

        private void PUNTO_Clicked_18(object sender, EventArgs e)
        {
           
            if (!caja.Text.Contains("."))
            {
                caja.Text = caja.Text + ".";
            }
        }

        private void IGUAL_Clicked_19(object sender, EventArgs e)
        {
            d2 = double.Parse(caja.Text);
            if (opera == "+")
            {
                resul = d1 + d2;
                caja.Text = resul.ToString();
                secuencia = true;
            }
            if (opera == "-")
            {
                resul = d1 - d2;
                caja.Text = resul.ToString();
                secuencia = true;
            }
            if (opera == "*")
            {
                resul = d1 * d2;
                caja.Text = resul.ToString();
                secuencia = true;
            }
            if (opera == "/")
            {
                resul = d1 / d2;
                caja.Text = resul.ToString();
                secuencia = true;
            }
        }

        private void C_Clicked_20(object sender, EventArgs e)
        {
            caja.Text = "0";
            d1 = 0;
            d2 = 0;
            secuencia = true;
        }

        private void CE_Clicked_21(object sender, EventArgs e)
        {
            int x = 0;
            borrado = caja.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            caja.Text = borrado;

            if (caja.Text == "")
            {
                caja.Text = "0";
                secuencia = true;
            }
            if (caja.Text == "-")
            {
                caja.Text = "0";
                secuencia = true;
            }
        }

        private void NEXT_Clicked_22(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new MasterDetailPage1()));
        }
    }
}