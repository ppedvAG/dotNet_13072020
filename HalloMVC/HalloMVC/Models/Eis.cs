using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HalloMVC.Models
{
    public class Eis
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Preis { get; set; }

        public bool MilchEis { get; set; }
    }
}
