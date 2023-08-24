using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

using Xamarin.Forms;

namespace AppBancoDigital.View
{
    namespace PikerInXamarin.View
    { 
    public class Operadora : ContentPage
    {
        private Picker _picker;
        private Button _button;
        private Entry _entry;
        public Operadora()
        {
            this.Title = "Operadoras";

            List<Operadora> operadoras = new List<Operadora>();
            operadoras.Add(new Operadora() { Id = 1, Name = Claro });
            operadoras.Add(new Operadora() { Id = 1, Name = Tim });



            }

    }
}