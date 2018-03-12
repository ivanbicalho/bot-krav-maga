using System;
using System.Threading.Tasks;
using BotKravMaga.Bot.AI;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;

namespace BotKravMaga.Bot.Dialogs
{
    [Serializable]
    public class KravMagaDialog : LuisDialog<object>
    {
        public KravMagaDialog(ILuisService luisService)
            : base(luisService)
        {
        }

        [LuisIntent(Intent.NONE)]
        public async Task NoneAsync(IDialogContext context, LuisResult result)
        {
            await Intent.ProcessAsync(Intent.NONE, context, result);
        }

        [LuisIntent(Intent.DEFINICAO_KRAV_MAGA)]
        public async Task DefinicaoKravMagaAsync(IDialogContext context, LuisResult result)
        {
            await Intent.ProcessAsync(Intent.DEFINICAO_KRAV_MAGA, context, result);
        }

        [LuisIntent(Intent.SOBRE_O_BOT)]
        public async Task SobreBotAsync(IDialogContext context, LuisResult result)
        {
            await Intent.ProcessAsync(Intent.SOBRE_O_BOT, context, result);
        }

        [LuisIntent(Intent.SOBRE_MESTRE_KOBI)]
        public async Task SobreMestreKobiAsync(IDialogContext context, LuisResult result)
        {
            await Intent.ProcessAsync(Intent.SOBRE_MESTRE_KOBI, context, result);
        }

        [LuisIntent(Intent.ONDE_TREINAR)]
        public async Task OndeTreinarAsync(IDialogContext context, LuisResult result)
        {
            await Intent.ProcessAsync(Intent.ONDE_TREINAR, context, result);
        }

        [LuisIntent(Intent.SOBRE_O_CRIADOR)]
        public async Task SobreCriadorAsync(IDialogContext context, LuisResult result)
        {
            await Intent.ProcessAsync(Intent.SOBRE_O_CRIADOR, context, result);
        }

        [LuisIntent(Intent.SAUDACAO)]
        public async Task SaudacaoAsync(IDialogContext context, LuisResult result)
        {
            await Intent.ProcessAsync(Intent.SAUDACAO, context, result);
        }

        [LuisIntent(Intent.RECONHECER_LOGO)]
        public async Task ReconhecerLogoAsync(IDialogContext context, LuisResult result)
        {
            await Intent.ProcessAsync(Intent.RECONHECER_LOGO, context, result);
        }

        [LuisIntent(Intent.FAIXAS_KRAV_MAGA)]
        public async Task FaixasKravMagaAsync(IDialogContext context, LuisResult result)
        {
            await Intent.ProcessAsync(Intent.FAIXAS_KRAV_MAGA, context, result);
        }
    }
}
