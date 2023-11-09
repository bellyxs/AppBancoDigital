using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.PastaPix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListagemPix : ContentPage
    {
        public ListagemPix()
        {
            InitializeComponent();

            voltar.Source = ImageSource.FromResource("AppBancoDigital.Imagens.voltar.png");
        }

        private void voltar_Clicked(object sender, EventArgs e)
        {

        }

        private void QRCode_Clicked(object sender, EventArgs e)
        {

        }

        private void ChavePix_Clicked(object sender, EventArgs e)
        {

        }

        private void Copia_Clicked(object sender, EventArgs e)
        {

        }
    }
}