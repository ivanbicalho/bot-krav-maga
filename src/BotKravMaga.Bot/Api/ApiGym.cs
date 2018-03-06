using BotKravMaga.Bot.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace BotKravMaga.Bot.Api
{
    public static class ApiGym
    {
        private static HttpClient httpClient = new HttpClient();
        private const string URL_API = "https://botkravmaga.azurewebsites.net/api/gyms";

        public static async Task<IEnumerable<Gym>> GetAllGymsAsync()
        {
            var result = await httpClient.GetAsync(URL_API);
            if (!result.IsSuccessStatusCode)
            {
                throw new Exception("Ocorreu um erro ao buscar as academias");
            }

            return await result.Content.ReadAsAsync<IEnumerable<Gym>>();
        }
    }
}