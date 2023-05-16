using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo_banco.Source = ImageSource.FromResource("AppBancoDigital.Imagens.logo_banco.png");

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Cadastro());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Login());
        }
    }
}