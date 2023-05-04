using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace AppBancoDigital.Service
{
    public class DataService
    {
        private static readonly string servidor = "http://10.0.2.2:8000";

        protected static async Task<string> GetDataFromService(string rota)
        {
            string json_response;

            string uri = servidor + rota;

            var current = Connectivity.NetworkAccess;

            if (current != NetworkAccess.Internet)
            {
                throw new Exception("Por favor, conecte-se à uma rede de internet.");
            }

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    json_response = response.Content.ReadAsStringAsync().Result;
                }
                else
                    throw new Exception(DecodeServerError(response.StatusCode));
            }

            return json_response;
        }



        protected static async Task<string> PostDataToService(string json_object, string rota)
        {
            string json_response;

            string uri = servidor + rota;

            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                throw new Exception("Por favor, conecte-se à uma rede de internet.");
            }

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(
                    uri,
                    new StringContent(json_object, Encoding.UTF8, "application/json")
                );

                if (response.IsSuccessStatusCode)
                {
                    json_response = response.Content.ReadAsStringAsync().Result;
                }
                else
                    throw new Exception(DecodeServerError(response.StatusCode));
            }

            return json_response;
        }

        private static string DecodeServerError(System.Net.HttpStatusCode status_code)
        {
            string msg_erro;

            switch (status_code)
            {
                case System.Net.HttpStatusCode.BadRequest:
                    msg_erro = "O pedido não pode ser atendido no momento. Tente novamente mais tarde.";
                    break;

                case System.Net.HttpStatusCode.NotFound:
                    msg_erro = "Recurso não encontrado. Tente novamente mais tarde.";
                    break;

                case System.Net.HttpStatusCode.InternalServerError:
                    msg_erro = "O banco de dados está temporariamente indisponível. Tente novamente mais tarde.";
                    break;

                case System.Net.HttpStatusCode.RequestTimeout:
                    msg_erro = "O servidor está lento. Tente novamente.";
                    break;

                case System.Net.HttpStatusCode.Forbidden:
                    msg_erro = "Recurso temporariamente indisponível. Tente novamente mais tarde.";
                    break;

                default:
                    msg_erro = "Estamos com dificuldades para acessar o servidor, tente novamente.";
                    break;
            }

            return msg_erro;

        }
    }
}