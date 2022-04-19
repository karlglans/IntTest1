using IntTest.Api.Data;
using IntTest.Api.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1
{
    public static class Utilities
    {
        public static void InitializeDbForTests(MyDbContext db)
        {
            db.Fruits.AddRange(GetSeedingMessages());
            db.SaveChanges();
        }

        public static void ReinitializeDbForTests(MyDbContext db)
        {
            db.Fruits.RemoveRange(db.Fruits);
            InitializeDbForTests(db);
        }

        public static List<Fruit> GetSeedingMessages()
        {
            return new List<Fruit>()
            {
                new Fruit(){ Name = "Banana", Id = "ettan" },
                new Fruit(){ Name = "Apple", Id = "tvåan" },
                new Fruit(){ Name = "Päron", Id = "trean" }
            };
        }
    }
}
