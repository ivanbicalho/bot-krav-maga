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
    public class Saudacao : IIntent
    {
        public string Intent => AI.Intent.SAUDACAO;

        public async Task ProcessAsync(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Opa, tudo bem? O que você gostaria de saber de Krav-Magá?");
            context.Done<string>(null);
        }
    }
}