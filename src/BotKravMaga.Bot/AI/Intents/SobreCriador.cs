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
    public class SobreCriador : IIntent
    {
        public string Intent => AI.Intent.SOBRE_O_CRIADOR;

        public async Task ProcessAsync(IDialogContext context, LuisResult result)
        {
            var imageImi = context.MakeMessage();
            imageImi.Attachments.Add(Images.Imi);

            await context.PostAsync(imageImi)
                .ContinueWith(task => context.PostAsync("Imi Lichtenfeld é o seu nome. Ensinou a homens simples como utilizar o próprio corpo, transformando-os em soldados imbatíveis. A eficácia de seus ensinamentos surpreende e sua obra é reconhecida no mundo todo. Sua criação torna-se a filosofia de defesa do Estado de Israel e unidades militares de elite ao redor do mundo utilizam suas técnicas."))
                .ContinueWith(task => ChatUtil.Typing(context, 2000))
                .ContinueWith(task => context.PostAsync("Algumas frases do Imi:"))                
                .ContinueWith(task => context.PostAsync(PhrasesImi()));

            context.Done<string>(null);
        }

        private static string PhrasesImi()
        {
            var message = new StringBuilder();

            message.Append($"* Seja bom o suficiente para evitar o conflito.{ChatUtil.NewLine}");
            message.Append($"* Resposta simples e natural para situação complicada.{ChatUtil.NewLine}");
            message.Append($"* Mínimo de movimento de defesa contra máximo movimento de ataque.{ChatUtil.NewLine}");
            message.Append($"* Faça: mas faça certo.{ChatUtil.NewLine}");
            message.Append($"* Reaja na proporção da necessidade.");

            return message.ToString();
        }
    }
}