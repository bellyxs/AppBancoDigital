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
    public partial class Pix : ContentPage
    {
        public Pix()
        {
            InitializeComponent();

            voltar.Source = ImageSource.FromResource("AppBancoDigital.Imagens.voltar.png");
            Transferencia.Source = ImageSource.FromResource("AppBancoDigital.Imagens.cobrar.png");
            Deposito.Source = ImageSource.FromResource("AppBancoDigital.Imagens.banco.png");
            QrCode.Source = ImageSource.FromResource("AppBancoDigital.Imagens.qrcode.png");
        }

        private void btnBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Receber_Clicked(object sender, EventArgs e)
        {
           /** Navigation.PushAsync(new PixReceber());*/
        }

        private void Transferencia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PixTransferencia());
        }

        private void QrCode_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PixQRCode());
        }

        private void Deposito_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PixDeposito());

        }
    }
}
    