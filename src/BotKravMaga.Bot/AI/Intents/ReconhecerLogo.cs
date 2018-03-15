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
    public class ReconhecerLogo : IIntent
    {
        public string Intent => AI.Intent.RECONHECER_LOGO;

        public async Task ProcessAsync(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Ok, me envia uma imagem ou um link de uma imagem que consigo te falar se é ou não o logo do Krav-Magá...");
            context.Wait(ProcessarImagemAsync);
        }

        private static async Task ProcessarImagemAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var activity = await result;

            Uri url;

            if (activity.Attachments?.Any() == true)
                url = new Uri(activity.Attachments[0].ContentUrl);
            else
                Uri.TryCreate(activity.Text, UriKind.Absolute, out url);

            if (url == null)
            {
                await context.PostAsync("Isso não é uma imagem ou um link de uma imagem, envie novamente...");
                return;
            }

            var isLogoKravMaga = await ApiPrediction.IsLogoKravMagaAsync(url);
            await context.PostAsync(isLogoKravMaga ? "YES! Isso é um logo do Krav-Magá." : "NOPS! Isso não é um logo do Krav-Magá.");

            context.Done<string>(null);
        }
    }
}