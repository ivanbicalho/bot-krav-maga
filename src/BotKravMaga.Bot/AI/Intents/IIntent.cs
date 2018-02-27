using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BotKravMaga.Bot.AI.Intents
{
    public interface IIntent
    {
        string Intent { get; }
        Task ProcessAsync(IDialogContext context, LuisResult result);
    }
}