﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis.Models;

namespace BotKravMaga.Bot.AI.Intents
{
    public class SobreMestreKobi : IIntent
    {
        public string Intent => AI.Intent.SOBRE_MESTRE_KOBI;

        public async Task ProcessAsync(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Falar sobre o bot...");
            context.Done<string>(null);
        }
    }
}