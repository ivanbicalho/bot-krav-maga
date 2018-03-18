using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using BotKravMaga.Bot.Util;
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
            await context.PostAsync($"Eu ainda não tenho um nome! Mas veja o que consigo fazer:{ChatUtil.NewLine}{ChatUtil.GetBotCapabilitiesMessage()}")
                .ContinueWith(task => ChatUtil.Typing(context, 500))
                .ContinueWith(task => context.PostAsync($"Além disso, fui construído sob a plataforma de bots da Microsoft, depois dá uma olhadinha no meu site:{ChatUtil.NewLine}https://dev.botframework.com/"));
            context.Done<string>(null);
        }
    }
}