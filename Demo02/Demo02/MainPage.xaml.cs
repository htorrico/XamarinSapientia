using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dtpFechaNacimiento.BackgroundColor = Color.White;
            lblEdad.FontSize = 50;
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            lblSuma.Text =Convert.ToString( Convert.ToInt32(txtNumero1.Text) + Convert.ToInt32(txtNumero2.Text));

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

            lblResta.Text = Convert.ToString(Convert.ToInt32(txtNumero1.Text) - Convert.ToInt32(txtNumero2.Text));
            
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            lblMultiplica.Text = Convert.ToString(Convert.ToInt32(txtNumero1.Text) / Convert.ToInt32(txtNumero2.Text));
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {


            int edad = dtpFechaNacimiento.Date.Year - DateTime.Today.Year;


        }
    }
}
