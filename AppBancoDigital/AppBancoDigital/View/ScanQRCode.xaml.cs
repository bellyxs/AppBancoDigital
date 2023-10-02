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
    public partial class ScanQRCode : ContentPage
    {
        public ScanQRCode()
        {
            InitializeComponent();
        }

        private void btn_voltar_Clicked(object sender, EventArgs e)
        {

        }
    }
}