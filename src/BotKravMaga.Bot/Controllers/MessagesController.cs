﻿using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Linq;
using BotKravMaga.Bot.Util;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Connector;
using System.Text;

namespace BotKravMaga.Bot
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        public async Task<HttpResponseMessage> PostAsync([FromBody]Activity activity)
        {
            switch (activity.Type)
            {
                case ActivityTypes.Message:
                    await HandleMessageAsync(activity);
                    break;
                case ActivityTypes.ConversationUpdate:
                    await HandleConversationUpdateAsync(activity);
                    break;
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        private async static Task HandleMessageAsync(Activity activity)
        {
            await TypingAsync(activity);

            var luisService = new LuisService(new LuisModelAttribute(Config.LuisId, Config.LuisSubscriptionKey));

            await Conversation.SendAsync(activity, () => new Dialogs.KravMagaDialog(luisService));
        }

        private static async Task HandleConversationUpdateAsync(Activity activity)
        {
            if (activity.MembersAdded.Any(o => o.Id == activity.Recipient.Id))
            {
                using (var connector = new ConnectorClient(new Uri(activity.ServiceUrl)))
                {
                    var reply = activity.CreateReply();
                    reply.Text = $"Olá, eu sou o Bot de Krav-Magá. Olha o que consigo te fornecer:{ChatUtil.NewLine}{ChatUtil.GetBotCapabilitiesMessage()}";

                    await connector.Conversations.ReplyToActivityAsync(reply);
                }
            }
        }

        private async static Task TypingAsync(Activity activity)
        {
            using (var connector = new ConnectorClient(new Uri(activity.ServiceUrl)))
            {
                var reply = activity.CreateReply();
                reply.Type = ActivityTypes.Typing;
                reply.Text = null;

                await connector.Conversations.ReplyToActivityAsync(reply);
            }
        }
    }
}