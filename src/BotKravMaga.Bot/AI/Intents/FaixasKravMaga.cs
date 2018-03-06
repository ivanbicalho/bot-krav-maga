using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis.Models;

namespace BotKravMaga.Bot.AI.Intents
{
    public class FaixasKravMaga : IIntent
    {
        public string Intent => AI.Intent.FAIXAS_KRAV_MAGA;

        public async Task ProcessAsync(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("A graduação do Krav-Magá é composto das seguintes faixas:")
                .ContinueWith(ant => context.PostAsync("Branca, Amarela, Laranja, Verde, Azul, Marrom e Preta"))
                .ContinueWith(ant => context.PostAsync("Na faixa preta, existem 5 dans e, após, existe ainda uma sequência da faixa branca e vermelha. Olha a imagem abaixo pra vc entender um pouco melhor:"))
                .ContinueWith(ant => context.PostAsync("https://botkravmaga.blob.core.windows.net/images/faixas.png"));

            context.Done<string>(null);
        }
    }
}