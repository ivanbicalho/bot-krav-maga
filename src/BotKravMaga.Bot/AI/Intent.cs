using BotKravMaga.Bot.AI.Intents;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;

namespace BotKravMaga.Bot.AI
{
    public static class Intent
    {
        public const string NONE = "";
        public const string SOBRE_O_BOT = "sobre-o-bot";
        public const string SOBRE_MESTRE_KOBI = "sobre-mestre-kobi";
        public const string ONDE_TREINAR = "onde-treinar";
        public const string SOBRE_O_CRIADOR = "sobre-o-criador";
        public const string SAUDACAO = "saudacao";
        public const string RECONHECER_LOGO = "reconhecer-logo";
        public const string FAIXAS_KRAV_MAGA = "faixas-krav-maga";
        public const string DEFINICAO_KRAV_MAGA = "definicao-krav-maga";

        public static async Task ProcessAsync(string intent, IDialogContext context, LuisResult result)
        {
            var intentTypes = Assembly.GetExecutingAssembly().GetTypes().Where(type =>
                type.IsClass
                && typeof(IIntent).IsAssignableFrom(type)
                && type.GetCustomAttribute<CompilerGeneratedAttribute>() == null);

            foreach (var intentType in intentTypes)
            {
                var instance = ((IIntent)Activator.CreateInstance(intentType));
                if (instance.Intent == intent)
                {
                    await instance.ProcessAsync(context, result);
                    return;
                }
            }

            throw new Exception("Intenção não encontrada");
        }
    }
}