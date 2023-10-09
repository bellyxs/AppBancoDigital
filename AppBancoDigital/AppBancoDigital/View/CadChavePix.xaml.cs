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
    public partial class CadChavePix : ContentPage
    {
        public CadChavePix()
        {
            InitializeComponent();

            voltar.Source = ImageSource.FromResource("AppBancoDigital.Imagens.voltar.png");

        }

        private void voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pix());
        }
    }
}