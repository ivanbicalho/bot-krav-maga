using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;

namespace BotKravMaga.Bot.AI.Intents
{
    public class SobreBot : IIntent
    {
        public string Intent => AI.Intent.SOBRE_O_BOT;

        public async Task ProcessAsync(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Eu ainda não tenho um nome, fui treinado para falar sobre o Krav-Magá. Fui construído sob a plataforma de Bots da Microsoft, depois dá uma olhadinha no meu site:")
                .ContinueWith(ant => context.PostAsync("https://dev.botframework.com/"));
            context.Done<string>(null);
        }
    }
}