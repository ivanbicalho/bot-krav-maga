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
    public class DefinicaoKravMaga : IIntent
    {
        public string Intent => AI.Intent.DEFINICAO_KRAV_MAGA;

        public async Task ProcessAsync(IDialogContext context, LuisResult result)
        {
            await context
                .PostAsync("O Krav Maga é a única  luta reconhecida mundialmente como arte de defesa pessoal e não como arte marcial. A concepção do Krav Maga revela um caminho que permite qualquer um exercer o direito à vida, mesmo no cenário violento que nos rodeia.")
                .ContinueWith(ant => context.PostAsync("Não há regras ou competições, pois sua técnica visa à legítima defesa em situações de perigo real. Com respostas simples, rápidas e objetivas para situações de violência do dia a dia, mostra ao cidadão comum como se defender, independentemente de condicionamento físico, idade ou sexo."));
            context.Done<string>(null);
        }
    }
}