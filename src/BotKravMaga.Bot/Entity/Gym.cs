using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BotKravMaga.Bot.Entity
{
    public class Gym
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("instructors")]
        public IEnumerable<string> Instructors { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("phones")]
        public IEnumerable<string> Phones { get; set; }
    }
}