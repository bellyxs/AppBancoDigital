using AppBancoDigital.Model;
using AppBancoDigital.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Correntistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroCorrentista : ContentPage
    {
        public CadastroCorrentista()
        {
            
            InitializeComponent();
            fim_cad.BackgroundColor = Color.FromRgba(0, 0, 0, 64);
            voltar.BackgroundColor = Color.FromRgba(0, 0, 0, 64);
            frame_cadastro.BackgroundColor = Color.FromRgba(0, 0, 0, 50);
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
                    data_nasc = dtpck_datanasc.Date,
                    cpf = txt_cpf.Text.Replace(".", string.Empty).Replace("-", string.Empty)
                });

                if (c != null)
                {
                    string msg = $"Correntista inserido com sucesso. Execute seu login.";

                    await DisplayAlert("Sucesso!", msg, "OK");

                    await Navigation.PushAsync(new View.Correntistas.LoginCorrentista());
                }
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