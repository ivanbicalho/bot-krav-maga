using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BotKravMaga.Bot.Entity
{
    public class Address
    {
        public string Neighborhood { get; set; }

        public string Street { get; set; }

        public string Number { get; set; }
    }
}