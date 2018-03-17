using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using BotKravMaga.Bot.Api;
using BotKravMaga.Bot.Entity;
using BotKravMaga.Bot.Util;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;

namespace BotKravMaga.Bot.AI.Intents
{
    public class OndeTreinar : IIntent
    {
        public string Intent => AI.Intent.ONDE_TREINAR;

        public async Task ProcessAsync(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Atualmente, consigo te falar sobre as academias de Krav-Magá em Belo Horizonte. Espera um pouco enquanto busco as informações...")
                .ContinueWith(task => ChatUtil.Typing(context));

            var gyms = await ApiGym.GetAllGymsAsync();

            await context.PostAsync("Veja as academias que encontrei:")
                .ContinueWith(task => ChatUtil.Typing(context, 700))
                .ContinueWith(task => context.PostAsync(GetGymAsMessage(gyms)));

            context.Done<string>(null);
        }

        private static string GetGymAsMessage(IEnumerable<Gym> gyms)
        {
            var message = new StringBuilder();

            foreach (var gym in gyms)
            {
                message.Append($"**Academia:** {gym.Name}{ChatUtil.NewLine}");
                message.Append($"**Endereço:** {gym.Address.CompleteAddress}{ChatUtil.NewLine}");
                message.Append($"**Tel(s):** {string.Join(", ", gym.Phones)}{ChatUtil.NewLine}");
                message.Append($"**Instrutores:** {string.Join(", ", gym.Instructors)}{ChatUtil.NewLine}");
                message.Append($"___{ChatUtil.NewLine}");
            }

            return message.ToString();
        }
    }
}