using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace BotKravMaga.Bot.Util
{
    public static class Config
    {
        public static string LuisId
        {
            get { return GetKey(nameof(LuisId)); }
        }

        public static string LuisSubscriptionKey
        {
            get { return GetKey(nameof(LuisSubscriptionKey)); }
        }

        public static string CustomVisionUrl
        {
            get { return GetKey(nameof(CustomVisionUrl)); }
        }

        public static string CustomVisionPredictionKey
        {
            get { return GetKey(nameof(CustomVisionPredictionKey)); }
        }


        private static string GetKey(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}