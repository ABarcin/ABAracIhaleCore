using AB_AracIhaleCore.UI.Models.ApiModels;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace AB_AracIhaleCore.UI.Provider
{
    public class TokenProvider
    {
        HttpClient _client;
        public TokenProvider(HttpClient client)
        {
            _client = client;
        }
        public async Task<string> TokenAl(string kullaniciAdi, string sifre)
        {
            StringContent mycontent = new StringContent(JsonConvert.SerializeObject(new MyLoginDTO()
            {
                Password = sifre,
                UserName = kullaniciAdi
            }));
            mycontent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var deger = await _client.PostAsync("auth/login", mycontent);
            string token = "";
            if (deger.IsSuccessStatusCode)
            {
                token = deger.Content.ReadAsStringAsync().Result;
            }
            else
            {
                token = "";
            }
            return token;
        }
    }
}
