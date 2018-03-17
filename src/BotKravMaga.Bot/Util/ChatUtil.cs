using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}