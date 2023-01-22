using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truco.Models;
using Truco.ViewModels;
using Truco.Views;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace Truco.Views
{
    public partial class ItemsPage : ContentPage
    {

        int incremento;
        int decremento;

        int winsyo;
        int winsmamita1;
        int winsmamita2;

        public ItemsPage()
        {
            InitializeComponent();
            incremento = 1;
            decremento = 1;
            winsyo = 0;
            winsmamita1 = 0;
             winsmamita2 = 0;
        }



        private void Button_Clicked(object sender, EventArgs e)
        {
            ContadorAutomaticoLabel.Text = (Convert.ToInt64(ContadorAutomaticoLabel.Text) - decremento).ToString();

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            ContadorAutomaticoLabel1.Text = (Convert.ToInt64(ContadorAutomaticoLabel1.Text) - decremento).ToString();

        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            

            if (ContadorAutomaticoLabel1.Text == "29")
            {
                botonR2.IsVisible = false;
                botonS2.IsVisible = false;

                winsmamita1++;
                await DisplayAlert("Que locura", "Gano " + mamitatxt.Text + " y se convirtio en la mamita suprema del lugar", "Que honor");

                ContadorAutomaticoLabel1.Text = (Convert.ToInt64(ContadorAutomaticoLabel1.Text) + 1).ToString();

            }
            else
            {
                ContadorAutomaticoLabel1.Text = (Convert.ToInt64(ContadorAutomaticoLabel1.Text) + incremento).ToString();
            }
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            
            if (ContadorAutomaticoLabel.Text == "29")
            {
                botonR1.IsVisible = false;
                botonS1.IsVisible = false;
                await DisplayAlert("Que locura", "Ganaste y te convirtiste en la mamita suprema del lugar", "Que honor");
                winsyo++;

                ContadorAutomaticoLabel.Text = (Convert.ToInt64(ContadorAutomaticoLabel.Text) + 1).ToString();


            }
            else
            {
                ContadorAutomaticoLabel.Text = (Convert.ToInt64(ContadorAutomaticoLabel.Text) + incremento).ToString();
            }
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            if (ContadorAutomaticoLabel2.Text == "29")
            {
                botonR3.IsVisible = false;
                botonS3.IsVisible = false;

                await DisplayAlert("Que locura", "Gano " +santatxt.Text+ " y se convirtio en la mamita suprema del lugar", "Que honor");
                winsmamita2++;

                ContadorAutomaticoLabel2.Text = (Convert.ToInt64(ContadorAutomaticoLabel2.Text) + 1).ToString();

            }
            else
            {
                ContadorAutomaticoLabel2.Text = (Convert.ToInt64(ContadorAutomaticoLabel2.Text) + incremento).ToString();
            }
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            ContadorAutomaticoLabel2.Text = (Convert.ToInt64(ContadorAutomaticoLabel2.Text) - incremento).ToString();
        }


        public void limpiador()
        {
            ContadorAutomaticoLabel.Text = "0";
            ContadorAutomaticoLabel1.Text = "0";
            ContadorAutomaticoLabel2.Text = "0";

            botonR1.IsVisible = true;
            botonS1.IsVisible = true;

            botonR2.IsVisible = true;
            botonS2.IsVisible = true;

            botonR3.IsVisible = true;
            botonS3.IsVisible = true;



            contyotxt.Text = "Victorias: " + winsyo;
            contmamitatxt.Text = "Victorias: " + winsmamita1;
            contmamita2txt.Text = "Victorias: " + winsmamita2;
        }

        private void botonreinicio_Clicked(object sender, EventArgs e)
        {
            limpiador();
        }
    }
}