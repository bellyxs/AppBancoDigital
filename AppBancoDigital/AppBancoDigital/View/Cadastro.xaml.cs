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
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            
            InitializeComponent();
            fim_cad.BackgroundColor = Color.FromRgba(0, 0, 0, 64);
            voltar.BackgroundColor = Color.FromRgba(0, 0, 0, 64);
            NavigationPage.SetHasNavigationBar(this, false);
            cadastro_icon.Source = ImageSource.FromResource("AppBancoDigital.Imagens.cadastro_icon.png");
        }

            private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Correntista c = await DataServiceCorrentista.Cadastrar(new Correntista
                {
                    nome = txt_nome.Text,
                    senha = txt_senha.Text,
                    data_nasc = dtpck_datanasc.Date.ToString("dd/MM/yyyy"),
                    cpf = txt_cpf.Text
                });

                string msg = $"Correntista inserido com sucesso. Código gerado: {c.id} ";

                await DisplayAlert("Sucesso!", msg, "OK");

                await Navigation.PushAsync(new View.Login());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void dtpck_datanasc_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}