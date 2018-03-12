﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
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
            var imageReply = context.MakeMessage();
            imageReply.Attachments.Add(GetGraduationImage());

            await context.PostAsync("A graduação do Krav-Magá é composto das seguintes faixas:")
                .ContinueWith(ant => context.PostAsync("Branca, Amarela, Laranja, Verde, Azul, Marrom e Preta"))
                .ContinueWith(ant => context.PostAsync("Na faixa preta, existem 5 dans e, após, existe ainda uma sequência da faixa branca e vermelha. Veja a imagem abaixo pra você entender um pouco melhor:"))
                .ContinueWith(ant => context.PostAsync(imageReply));

            context.Done<string>(null);
        }

        private static Attachment GetGraduationImage()
        {
            return new Attachment
            {
                ContentUrl = "https://botkravmaga.blob.core.windows.net/images/faixas.png",
                ContentType = "image/png",
                Name = "faixas.png"
            };
        }
    }
}