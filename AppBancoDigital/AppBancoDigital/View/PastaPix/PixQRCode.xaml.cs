using QRCoder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PixQRCode : ContentPage
    {
        public PixQRCode()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            voltar.Source = ImageSource.FromResource("AppBancoDigital.Imagens.voltar.png");
            btn_gerar.BackgroundColor = Color.FromRgba(0, 0, 0, 45);

        }

        private void btn_gerar_Clicked(object sender, EventArgs e)
        {
            string teste = "Chave da Transferência: abc";

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(teste, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qRCode.GetGraphic(20);
            img_qr.Source = ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));
        }

        private void btn_voltar_Clicked(object sender, EventArgs e)
        {

        }
        private void voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pix());

        }
    }
}