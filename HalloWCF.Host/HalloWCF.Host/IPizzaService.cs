using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HalloWCF.Host
{
    [ServiceContract]
    public interface IPizzaService
    {
        [OperationContract]
        IEnumerable<Pizza> GetPizzaListe();
    }

    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Preis { get; set; }
        public string PreisUnit { get; set; } = "€";
    }

}
