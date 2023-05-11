using AppBancoDigital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppBancoDigital.Service
{
    public class DataServiceCorrentista : DataService
    {
        public static async Task<Correntista> Cadastrar(Correntista c)
        {
            var json_to_send = JsonConvert.SerializeObject(c);

            string json = await DataService.PostDataToService(json_to_send, "/correntista/save");

            Correntista correntista = JsonConvert.DeserializeObject<Correntista>(json);
            return correntista;
        }

        public static async Task<Correntista> Autorizar(Correntista c)
        {
            var json_to_send = JsonConvert.SerializeObject(c);

            string json = await DataService.GetDataFromService(String.Format("/correntista/entrar?cpf={0}&senha={1}", c.cpf, c.senha));

            Correntista correntista = new Correntista();
            if (json != "false")
            {
                correntista = JsonConvert.DeserializeObject<Correntista>(json);
            }


            return correntista;
        }
    }
}