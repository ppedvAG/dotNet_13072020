using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst
{
    public class Auto
    {
        public int Id { get; set; }
        public string Farbe { get; set; }
        public int AnzahRäder { get; set; }
        public string Modell { get; set; }
        public string Hersteller { get; set; }
        public string SitzeFarbe { get; set; }
        public DateTime BauJahr { get; set; }
    }

    public class EfAutoContext : DbContext
    {
        public DbSet<Auto> Autos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>().Property(x => x.AnzahRäder).HasColumnName("TireCount").IsRequired();
        }
    }
}
