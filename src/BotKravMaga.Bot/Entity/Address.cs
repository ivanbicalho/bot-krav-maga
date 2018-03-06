using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BotKravMaga.Bot.Entity
{
    public class Address
    {
        [JsonProperty("neighborhood")]
        public string Neighborhood { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }
    }
}