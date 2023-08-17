using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaInicial : ContentPage
    {
        public PaginaInicial()
        {
            InitializeComponent();

            opcoes.BackgroundColor = Color.FromRgba(0, 0, 0, 64);
            olho.BackgroundColor = Color.FromRgba(0, 0, 0, 64);
            icon.BackgroundColor = Color.FromRgba(0, 0, 0, 50);
            /**olhoesconde.BackgroundColor = Color.FromRgba(0, 0, 0, 50);*/
            NavigationPage.SetHasNavigationBar(this, false);
            opcoes.Source = ImageSource.FromResource("AppBancoDigital.Imagens.opcoes.png");
            icon.Source = ImageSource.FromResource("AppBancoDigital.Imagens.login.png");
            olho.Source = ImageSource.FromResource("AppBancoDigital.Imagens.olho.png");
            Pix.Source = ImageSource.FromResource("AppBancoDigital.Imagens.pix.png");
            recarga.Source = ImageSource.FromResource("AppBancoDigital.Imagens.recarga.png");
            pagar.Source = ImageSource.FromResource("AppBancoDigital.Imagens.pagar.png");
            seguro.Source = ImageSource.FromResource("AppBancoDigital.Imagens.seguro.png");
            qrcode.Source = ImageSource.FromResource("AppBancoDigital.Imagens.qrcode.png");
            /**olhoesconde.Source = ImageSource.FromResource("AppBancoDigital.Imagens.olhoesconde.png");*/
        }
   private void opcoes_Clicked(object sender, EventArgs e)
        {

        }

        private void olho_Clicked(object sender, EventArgs e)
        {

        }

        private void olhoesconde_Clicked(object sender, EventArgs e)
        {

        }


        private void Pix_Clicked(object sender, EventArgs e)
        {

        }

        private void pagar_Clicked(object sender, EventArgs e)
        {

        }

        private void recarga_Clicked(object sender, EventArgs e)
        {

        }

        private void seguro_Clicked(object sender, EventArgs e)
        {

        }

        private void qrcode_Clicked(object sender, EventArgs e)
        {

        }
    }
}