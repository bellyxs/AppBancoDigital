using AppBancoDigital.Model;
using AppBancoDigital.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        private async void final_recarga_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Confirmação", "Gostaria de confirmar a sua recarga?", "Sim", "Não");
            Debug.WriteLine("Answer: " + answer);

            await DisplayAlert("Sucesso!", "Recarga Realizada", "OK");

            await Navigation.PushAsync(new View.PaginaInicial());

        }   
    }
}
