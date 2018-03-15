using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BotKravMaga.Bot.Entity
{
    public class Gym
    {
        public string Name { get; set; }

        public IEnumerable<string> Instructors { get; set; }

        public Address Address { get; set; }

        public IEnumerable<string> Phones { get; set; }
    }
}