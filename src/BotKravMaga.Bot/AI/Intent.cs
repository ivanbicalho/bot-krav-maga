using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BotKravMaga.Bot.AI
{
    public static class Intent
    {
        public const string NONE = "None";
        public const string SOBRE_O_BOT = "sobre-o-bot";
        public const string SOBRE_MESTRE_KOBI = "sobre-mestre-kobi";
        public const string ONDE_TREINAR = "onde-treinar";
        public const string SOBRE_O_CRIADOR = "sobre-o-criador";
        public const string SAUDACAO = "saudacao";
        public const string RECONHECER_LOGO = "reconhecer-logo";
        public const string FAIXAS_KRAV_MAGA = "faixas-krav-maga";
        public const string DEFINICAO_KRAV_MAGA = "definicao-krav-maga";

        public static Task ProcessAsync(string intent, IDialogContext context, LuisResult result)
        {
            Type t = null; // find intent
            return (Task)Activator.CreateInstance(t);
        }
    }
}