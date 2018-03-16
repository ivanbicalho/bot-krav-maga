using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using BotKravMaga.Bot.Util;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;

namespace BotKravMaga.Bot.AI.Intents
{
    public class FaixasKravMaga : IIntent
    {
        public string Intent => AI.Intent.FAIXAS_KRAV_MAGA;

        public async Task ProcessAsync(IDialogContext context, LuisResult result)
        {
            var imageGraduation = context.MakeMessage();
            imageGraduation.Attachments.Add(Images.Graduation);

            await context.PostAsync("A graduação do Krav-Magá é composto das seguintes faixas:")
                .ContinueWith(task => context.PostAsync("Branca, Amarela, Laranja, Verde, Azul, Marrom e Preta"))
                .ContinueWith(task => ConversationUtil.Typing(context, 1000))
                .ContinueWith(task => context.PostAsync("Na faixa preta, existem 5 dans e, após, existe ainda uma sequência da faixa branca e vermelha. Veja a imagem abaixo pra você entender um pouco melhor:"))
                .ContinueWith(task => ConversationUtil.Typing(context, 1000))
                .ContinueWith(task => context.PostAsync(imageGraduation));

            context.Done<string>(null);
        }
    }
}