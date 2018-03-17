using System;

namespace BotKravMaga.Bot.Entity
{
    public class Prediction
    {
        public static class Tags
        {
            public const string LogoKravMaga = "logo-krav-maga";
        }

        public string TagId { get; set; }
        public string Tag { get; set; }
        public double Probability { get; set; }
    }
}