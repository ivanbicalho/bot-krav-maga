using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using BotKravMaga.Bot.Api;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;

namespace BotKravMaga.Bot.AI.Intents
{
    public class OndeTreinar : IIntent
    {
        public string Intent => AI.Intent.ONDE_TREINAR;

        public async Task ProcessAsync(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Atualmente, consigo te falar sobre as academias de Krav-Magá em Belo Horizonte. Espera um pouco enquanto busco as informações...");

            //var gyms = await ApiGym.GetAllGymsAsync();            

            context.Done<string>(null);
        }
    }
}