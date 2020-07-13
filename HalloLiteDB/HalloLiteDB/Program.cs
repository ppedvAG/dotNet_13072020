using LiteDB;
using System;

namespace HalloLiteDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var db = new LiteDatabase(@"C:\db\lll.db"))
            {
                var col = db.GetCollection<Auto>("Autos");

                foreach (var item in col.Query().ToList())
                {
                    //Console.WriteLine($"Hersteller: {item.Hersteller}");
                    Console.WriteLine($"Farbe: {item.Farbe}");
                }

                //col.Insert(new Auto() { Hersteller = "Baudi",Farbe="blau" });
                //col.Insert(new Auto() { Farbe="rot" });


            }

            Console.ReadLine();
        }
    }

    public class Auto
    {
        public int Id { get; set; }

        public string Farbe { get; set; }
    }
}
