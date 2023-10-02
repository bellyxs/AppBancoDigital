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
    public partial class PixEnviar : ContentPage
    {
        public PixEnviar()
        {
            InitializeComponent();

            Voltar.Source = ImageSource.FromResource("AppBancoDigital.Imagens.voltar.png");

        }

        private void btnBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Voltar_Clicked(object sender, EventArgs e)
        {

        }
    }
}