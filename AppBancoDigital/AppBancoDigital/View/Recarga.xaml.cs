using AppBancoDigital.Model;
using AppBancoDigital.Service;
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
    public partial class Recarga : ContentPage
    {
        public Recarga()
        {
            InitializeComponent();
            final_recarga.BackgroundColor = Color.FromRgba(0, 0, 0, 64);
            voltar.Source = ImageSource.FromResource("AppBancoDigital.Imagens.voltar.png");
        }

        private void voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.PaginaInicial());
        }

        private void fin_recarga_Clicked(object sender, EventArgs e)
        {
            
        }

        private void final_recarga_Clicked(object sender, EventArgs e)
        {

        }
    }
}