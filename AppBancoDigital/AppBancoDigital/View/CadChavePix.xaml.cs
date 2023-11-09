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
    public partial class CadChavePix : ContentPage
    {
        public CadChavePix()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            voltar.Source = ImageSource.FromResource("AppBancoDigital.Imagens.voltar.png");
            continuar_cadastro.BackgroundColor = Color.FromRgba(0, 0, 0, 64);
        }

        private void voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pix());
        }

        private async void continuar_cadastro_Clicked(object sender, EventArgs e)
        {
            try
            {
                string tipo_da_chave = pickerchavepix.SelectedItem.ToString();
                string chave_pix = txtpix.Text;

                await DataServiceChavePix.Adicionar(new ChavePix
                {
                    tipo = tipo_da_chave,
                    chave = chave_pix
                });
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");

            }


            
        }
    }
}