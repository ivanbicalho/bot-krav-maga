using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BotKravMaga.Bot.Util
{
    public static class ChatUtil
    {
        public static string NewLine
        {
            get { return "  \n"; }
        }

        public static void Typing(IDialogContext context, int? milliseconds = null)
        {
            var message = context.MakeMessage();
            message.Type = ActivityTypes.Typing;

            context.PostAsync(message);

            if (milliseconds.HasValue)
                System.Threading.Thread.Sleep(milliseconds.Value);
        }

        public static string GetBotCapabilitiesMessage()
        {
            var message = new StringBuilder();

            message.Append($"* Falar um pouco sobre mim{NewLine}");
            message.Append($"* Sobre o Krav-Magá{NewLine}");
            message.Append($"* Sobre a graduação ou faixas do Krav-Magá{NewLine}");
            message.Append($"* Onde você pode treinar{NewLine}");
            message.Append($"* Sobre o criador do Krav-Magá{NewLine}");
            message.Append($"* Sobre a mestre{NewLine}");
            message.Append($"* Reconhecer se uma imagem é a logo do Krav-Magá");

            return message.ToString();
        }
    }
}