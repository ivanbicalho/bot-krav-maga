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
    public class SobreMestreKobi : IIntent
    {
        public string Intent => AI.Intent.SOBRE_MESTRE_KOBI;

        public async Task ProcessAsync(IDialogContext context, LuisResult result)
        {
            var imageKobi = context.MakeMessage();
            imageKobi.Attachments.Add(Images.Kobi);

            await context.PostAsync(imageKobi)
                .ContinueWith(ant => context.PostAsync("Kobi Lichtenstein nascido em 1964, em Israel, aos três anos iniciou-se nos treinamentos de Krav Maga ministrados por Imi Lichtenfeld. Destacando-se como um \"prodígio\" aos 15 anos começou a dar as primeiras aulas. Hoje, supervisiona a prática e divulgação do Krav Maga, mantendo o alto nível ético e técnico dos instrutores e alunos, seguindo os passos ditados por seu mestre e criador do Krav Maga."));

            context.Done<string>(null);
        }
    }
}