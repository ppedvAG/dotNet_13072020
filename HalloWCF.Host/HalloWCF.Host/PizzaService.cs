using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HalloWCF.Host
{
    public class PizzaService : IPizzaService
    {
        public IEnumerable<Pizza> GetPizzaListe()
        {
            yield return new Pizza()
            { Id = 1, Name = "Salami", Preis = 12.6m };

            yield return new Pizza()
            { Id = 2, Name = "Schinken", Preis = 13.6m };

            yield return new Pizza()
            { Id = 3, Name = "Hawai", Preis = 10m };
        }
    }
}
