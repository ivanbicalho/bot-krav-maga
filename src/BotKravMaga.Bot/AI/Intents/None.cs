using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis.Models;

namespace BotKravMaga.Bot.AI.Intents
{
    public class None : IIntent
    {
        public string Intent => AI.Intent.NONE;

        public async Task ProcessAsync(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(":( Foi mals, não entendi. Pode repetir, por favor?");
            context.Done<string>(null);
        }
    }
}