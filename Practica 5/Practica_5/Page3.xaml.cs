using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica_5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage

    {
        double v1, v2;
        string m;
        public Page3()
        {
            InitializeComponent();
        }

        public void op()
        {
            v2 = Convert.ToDouble(r.Text);
            switch (m)
            {
                case "suma":
                    r.Text = v1 + v2 + "";

                    break;

                case "resta":
                    r.Text = v1 - v2 + "";

                    break;

                case "multiplicacion":
                    r.Text = v1 * v2 + "";

                    break;

                case "division":
                    r.Text = v1 / v2 + "";

                    break;


            }

        }

        private void Borra_Clicked(object sender, EventArgs e)
        {
            r.Text = "";
            v2 = 0;
            v1 = 0;

        }

        private void bo_Clicked(object sender, EventArgs e)
        {
            r.Text = "";
            v1 = 0;
            v2 = 0;
        }

        private void porciento_Clicked(object sender, EventArgs e)
        {

        }

        private void division_Clicked(object sender, EventArgs e)
        {
            v1 = Convert.ToDouble(r.Text);
            m = "division";
            r.Text = "";
        }

        private void siete_Clicked(object sender, EventArgs e)
        {
            r.Text = r.Text + 7;
        }

        private void ocho_Clicked(object sender, EventArgs e)
        {
            r.Text = r.Text + 8;
        }

        private void nueve_Clicked(object sender, EventArgs e)
        {
            r.Text = r.Text + 9;
        }

        private void multi_Clicked(object sender, EventArgs e)
        {
            v1 = Convert.ToDouble(r.Text);
            m = "multiplicacion";
            r.Text = "";
        }

        private void cuatro_Clicked(object sender, EventArgs e)
        {
            r.Text = r.Text + 4;
        }

        private void cinco_Clicked(object sender, EventArgs e)
        {
            r.Text = r.Text + 5;
        }

        private void seis_Clicked(object sender, EventArgs e)
        {
            r.Text = r.Text + 6;
        }

        private void menos_Clicked(object sender, EventArgs e)
        {
            v1 = Convert.ToDouble(r.Text);
            m = "resta";
            r.Text = "";
        }

        private void uno_Clicked(object sender, EventArgs e)
        {
            r.Text = r.Text + 1;
        }

        private void dos_Clicked(object sender, EventArgs e)
        {
            r.Text = r.Text + 2;
        }

        private void tres_Clicked(object sender, EventArgs e)
        {
            r.Text = r.Text + 3;
        }

        private void mas_Clicked(object sender, EventArgs e)
        {
            v1 = Convert.ToDouble(r.Text);
            m = "suma";
            r.Text = "";

        }

        private void cero_Clicked(object sender, EventArgs e)
        {
            r.Text = r.Text + 0;
        }

        private void punto_Clicked(object sender, EventArgs e)
        {
            r.Text = r.Text + ".";
        }

        private void __Clicked(object sender, EventArgs e)
        {

        }

        private void __Clicked_1(object sender, EventArgs e)
        {

        }

        async  void btnPag4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());

        }

        private void igual_Clicked(object sender, EventArgs e)
        {
            op();
        }
    }
}
