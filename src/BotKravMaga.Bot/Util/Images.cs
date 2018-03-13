using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BotKravMaga.Bot.Util
{
    public static class Images
    {
        public static Attachment Graduation
        {
            get { return GetImage("https://botkravmaga.blob.core.windows.net/images/faixas.png", "image/png", "faixas.png"); }
        }

        public static Attachment Imi
        {
            get { return GetImage("https://botkravmaga.blob.core.windows.net/images/Imi.jpg", "image/jpg", "Imi.jpg"); }
        }

        public static Attachment Kobi
        {
            get { return GetImage("https://botkravmaga.blob.core.windows.net/images/Kobi.jpg", "image/jpg", "Kobi.jpg"); }
        }

        private static Attachment GetImage(string url, string type, string name)
        {
            return new Attachment
            {
                ContentUrl = url,
                ContentType = type,
                Name = name
            };
        }
    }
}