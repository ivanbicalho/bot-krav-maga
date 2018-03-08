using BotKravMaga.Api.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BotKravMaga.Api.Data
{
    public class DBGym
    {
        private static IEnumerable<Gym> _gyms = LoadGyms();

        public static IEnumerable<Gym> GetAll()
        {
            return _gyms;
        }

        //public IEnumerable<Gym> GetAll(string searchTerm)
        //{
        //    var objs = _gyms.Select(gym => new { Obj = gym, Text = $"{gym.Name}{gym.Address.}" });

        //    return objs
        //        .Where(obj => obj.Text.IndexOf(searchTerm, StringComparison.InvariantCultureIgnoreCase) != -1)
        //        .Select(obj => obj.Obj);
        //}

        private static IEnumerable<Gym> LoadGyms()
        {
            var gyms = new List<Gym>();

            gyms.Add(NewGym("Academia Top Fight Center", "Barreiro", "Avenida Sinfronio Brochado", "710", new[] { "031 97300-8589" }, new[] { "ADRIANO COURA" }));
            gyms.Add(NewGym("Centro de Krav Maga Belvedere", "Belvedere", "Rua Athos Moreira da Silva", "140", new[] { "(031) 3653-2616" }, new[] { "PEDRO MENICUCCI" }));
            gyms.Add(NewGym("Academia Morav Center", "Castelo", "Av. Presidente Tancredo Neves", "2071", new[] { "(31) 4123-0216", "(31) 98486-3592" }, new[] { "CRISTIANO MORAVIA", "ADRIANO COURA" }));
            gyms.Add(NewGym("Academia Mattioli", "Cidade Jardim", "Av. Raja Gabaglia", "501", new[] { "(31) 3291-3450", "(31) 98486-3592" }, new[] { "CRISTIANO MORAVIA" }));
            gyms.Add(NewGym("Academia CORPSS", "Dona Clara", "Av. Sebastião de Brito", "243", new[] { "(31) 3491-8036" }, new[] { "DIONESIO MARIOSI" }));
            gyms.Add(NewGym("CTKM - CENTRO DE TREINAMENTO DE KRAV MAGA", "Estoril", "Rua Engenheiro Ocelo Cirino", "343, 2º Piso", new[] { "(31) 3324-5938", "(31) 99198-1903" }, new[] { "CRISTIANO MORAVIA", "LEONARDO ALMEIDA", "GUSTAVO DINIZ", "RODRIGO LIMA" }));
            gyms.Add(NewGym("Academia Bomsuar", "Floresta", "Rua Itajubá", "608", new[] { "(31) 2512-4399" }, new[] { "DANIEL FREIRE" }));
            gyms.Add(NewGym("Centro Mineiro de Krav Maga (União Israelita de Belo Horizonte)", "Funcionários", "Rua Pernambuco", "326", new[] { "(31) 3213-7759" }, new[] { "CRISTIANO MORAVIA", "DAVID JOSE SCHICKLER", "GUSTAVO DINIZ" }));
            gyms.Add(NewGym("Corpore Iate Tênis Clube", "Pampulha", "Av Otacilio Negrao de Lima", "1350", new[] { "(31) 3441 0570", "34416311" }, new[] { "DIONESIO MARIOSI" }));
            gyms.Add(NewGym("Academia Acqua Sports Fitness", "Palmares", "Rua Coronel Jairo Pereira", "144", new[] { "(31) 3422-4127" }, new[] { "DIONESIO MARIOSI" }));
            gyms.Add(NewGym("Academia Lível", "Prado", "Rua Chopim", "271", new[] { "(31) 3332-5094" }, new[] { "GUILHERME LARA", "RODRIGO LIMA" }));
            gyms.Add(NewGym("Lukton Center", "Sagrada Familia", "Rua Conselheiro Lafaiete", "1707", new[] { "(31) 4109-0419" }, new[] { "DANIEL FREIRE", "JOSE CALDEIRA" }));
            gyms.Add(NewGym("BRAZILIAN TOP TEAM", "Santa Monica", "Avenida Dr. Alvaro Camargo", "1680", new[] { "(31) 3495-2374", "(31) 9926-0878" }, new[] { "DIONESIO MARIOSI" }));
            gyms.Add(NewGym("Academia Corpore Premium", "Santo Agostinho", "Rua Rodrigues Caldas", "458", new[] { "(031) 3291-0199", "3224-0711" }, new[] { "CRISTIANO MORAVIA" }));
            gyms.Add(NewGym("Academia Fitness BH", "Santo André", "Rua Glocinia", "220", new[] { "031 3245-7454" }, new[] { "ANTÔNIO JOSÉ TEODORO" }));
            gyms.Add(NewGym("Academia Club Fitness", "Silveira", "Rua Ilacir Pereira de Lima", "735", new[] { "(31) 3482-5749" }, new[] { "JOSE CALDEIRA" }));
            gyms.Add(NewGym("Academia Wanda Bambirra", "Sion", "Av. Uruguai", "473", new[] { "(31) 3281-2633" }, new[] { "LEONARDO ALMEIDA", "GUSTAVO DINIZ" }));

            return gyms;
        }

        private static Gym NewGym(string name, string neighborhood, string streetName, string streetNumber, string[] phones, string[] instructors)
        {
            return new Gym
            {
                Name = name,
                Instructors = instructors,
                Phones = phones,
                Address = new Address { Neighborhood = neighborhood, Street = streetName, Number = streetNumber }
            };
        }
    }
}