using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Truco.Views
{
    public partial class AboutPage : ContentPage
    {

        int incremento;
        int decremento;

        int winsyo;
        int winsmamita4;
        int winsmamita1;
        int winsmamita2;
        int winsmamita3;
        public AboutPage()
        {
            incremento = 1;
            decremento = 1;

            winsyo = 0;
            winsmamita4 = 0;
            winsmamita1 = 0;
            winsmamita2 = 0;
            winsmamita3 = 0;


            InitializeComponent();
        }



        public void limpiador()
        {
            ContadorAutomaticoLabel.Text = "0";
            ContadorAutomaticoLabel1.Text = "0";
            ContadorAutomaticoLabel2.Text = "0";
            ContadorAutomaticoLabel3.Text = "0";
            ContadorAutomaticoLabel4.Text = "0";


            botonR.IsVisible = true;
            botonS.IsVisible = true;

            botonR1.IsVisible = true;
            botonS1.IsVisible = true;

            botonR2.IsVisible = true;
            botonS2.IsVisible = true;

            botonR3.IsVisible = true;
            botonS3.IsVisible = true;

            botonR4.IsVisible = true;
            botonS4.IsVisible = true;



            contyotxt.Text = "Victorias: " + winsyo;
            contmamitatxt.Text = "Victorias: " + winsmamita1;
            contmamita1txt.Text = "Victorias: " + winsmamita2;
            contmamita2txt.Text = "Victorias: " + winsmamita3;
            contmamita3txt.Text = "Victorias: " + winsmamita4;
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            
            if (ContadorAutomaticoLabel.Text == "49")
            {
                botonR.IsVisible = false;
                botonS.IsVisible = false;

                await DisplayAlert("Que locura", "Ganaste y te convertiste en la mamita suprema del lugar", "Que honor");

                winsyo++;

                ContadorAutomaticoLabel.Text = (Convert.ToInt64(ContadorAutomaticoLabel.Text) + 1).ToString();

            }
            else
            {
                ContadorAutomaticoLabel.Text = (Convert.ToInt64(ContadorAutomaticoLabel.Text) + incremento).ToString();
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            
            ContadorAutomaticoLabel.Text = (Convert.ToInt64(ContadorAutomaticoLabel.Text) - decremento).ToString();
        }




        private async void Button_Clicked_2(object sender, EventArgs e)
        {

            if (ContadorAutomaticoLabel1.Text == "49")
            {
                botonR1.IsVisible = false;
                botonS1.IsVisible = false;

                await DisplayAlert("Que locura", "Gano " + mamitatxt.Text + " y se convirtio en la mamita suprema del lugar", "Que honor");
                winsmamita1++;


                ContadorAutomaticoLabel1.Text = (Convert.ToInt64(ContadorAutomaticoLabel1.Text) + 1).ToString();


            }
            else
            {
                ContadorAutomaticoLabel1.Text = (Convert.ToInt64(ContadorAutomaticoLabel1.Text) + incremento).ToString();
            }
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            
            ContadorAutomaticoLabel1.Text = (Convert.ToInt64(ContadorAutomaticoLabel1.Text) - decremento).ToString();
        }




        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            
            if (ContadorAutomaticoLabel2.Text == "49")
            {
                botonR2.IsVisible = false;
                botonS2.IsVisible = false;

                await DisplayAlert("Que locura", "Gano " + mamita1txt.Text + " y se convirtio en la mamita suprema del lugar", "Que honor");
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
            
            ContadorAutomaticoLabel2.Text = (Convert.ToInt64(ContadorAutomaticoLabel2.Text) - decremento).ToString();
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            if (ContadorAutomaticoLabel3.Text == "49")
            {
                botonR3.IsVisible = false;
                botonS3.IsVisible = false;

                await DisplayAlert("Que locura", "Gano " + mamita2txt.Text + " y se convirtio en la mamita suprema del lugar", "Que honor");
                winsmamita3++;



                ContadorAutomaticoLabel3.Text = (Convert.ToInt64(ContadorAutomaticoLabel3.Text) + 1).ToString();

            }
            else
            {
                ContadorAutomaticoLabel3.Text = (Convert.ToInt64(ContadorAutomaticoLabel3.Text) + incremento).ToString();
            }
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            ContadorAutomaticoLabel4.Text = (Convert.ToInt64(ContadorAutomaticoLabel4.Text) - incremento).ToString();

        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            ContadorAutomaticoLabel3.Text = (Convert.ToInt64(ContadorAutomaticoLabel3.Text) - incremento).ToString();

        }

        private async void Button_Clicked_9(object sender, EventArgs e)
        {
            if (ContadorAutomaticoLabel4.Text == "49")
            {
                botonR4.IsVisible = false;
                botonS4.IsVisible = false;

                await DisplayAlert("Que locura", "Gano " + mamita3txt.Text + " y se convirtio en la mamita suprema del lugar", "Que honor");

                winsmamita4++;



                ContadorAutomaticoLabel4.Text = (Convert.ToInt64(ContadorAutomaticoLabel4.Text) + 1).ToString();

            }
            else
            {
                ContadorAutomaticoLabel4.Text = (Convert.ToInt64(ContadorAutomaticoLabel4.Text) + incremento).ToString();
            }
        }

        private void botonreinicio_Clicked(object sender, EventArgs e)
        {
            limpiador();

        }
    }

}