using BotKravMaga.Bot.Entity;
using BotKravMaga.Bot.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BotKravMaga.Bot.Api
{
    public static class ApiPrediction
    {
        public static async Task<bool> IsLogoKravMagaAsync(Uri url)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Prediction-key", Config.CustomVisionPredictionKey);

                HttpResponseMessage response = null;

                var byteData = Encoding.UTF8.GetBytes("{ 'url': '" + url + "' }");

                using (var content = new ByteArrayContent(byteData))
                {
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    response = await client.PostAsync(Config.CustomVisionUrl, content).ConfigureAwait(false);
                }

                var responseString = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<CustomVisionResult>(responseString);
                var prediction = result.Predictions?.OrderByDescending(c => c.Probability).FirstOrDefault();
                
                if (prediction?.Tag == "logo-krav-maga" && prediction?.Probability > 0.75)
                    return await Task.FromResult(true);

                return await Task.FromResult(false);
            }
        }
    }
}