using AppBancoDigital.Service;
using AppBancoDigital.Model;
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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            voltar.BackgroundColor = Color.FromRgba(0, 0, 0, 64);
            entrar.BackgroundColor = Color.FromRgba(0, 0, 0, 64);
            NavigationPage.SetHasNavigationBar(this, false);
            login.Source = ImageSource.FromResource("AppBancoDigital.Imagens.login.png");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try                                                                                 
            {
                Correntista c = await DataServiceCorrentista.Autorizar(new Correntista
                {                                                                           
                    nome = txt_nome.Text,
                    cpf = txt_cpf.Text,
                    senha = txt_senha.Text
                });
                Console.WriteLine(c.id);
                if (c.id != 0)
                {
                    string msg = $"Correntista logado com sucesso. Código gerado: {c.id} ";

                    await DisplayAlert("Sucesso!", msg, "OK");

                    await Navigation.PushAsync(new View.PaginaInicial());
                }
                else
                {
                    string msg = $"Correntista não encontrado, tente logar novamente! ";

                    await DisplayAlert("Erro!", msg, "OK");

                    await Navigation.PushAsync(new View.PaginaInicial());
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
    }
}                                                                                             