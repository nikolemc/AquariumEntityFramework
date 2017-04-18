using AquariumEntityFramework.DataContext;
using AquariumEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquariumEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new AquariumContext();

            // SELECT * FROM Aquarium
            var allAquariums = db.Aquariums.ToList();


            // CREATE!

            db.Aquariums.AddOrUpdate(
               a => a.AquariumName,
              new Aquarium

              {
                  AquariumName = "Shedd Aquarium",
                  City = "Chicago"

              },
               new Aquarium
               {
                   AquariumName = "Monterey Bay Aquarium",
                   City = "Monterey"

               },
               new Aquarium
               {
                   AquariumName = "Audubon Aquarium of America",
                   City = "New Orleans"

               },
              new Aquarium
                {
                  AquariumName = "National Aquarium",
                  City = "Baltimore"
              });
            


            // READ

            var aquariums = db.Aquariums.ToList();


            // CREATE OCEAN
            
            db.Oceans.AddOrUpdate(
               a => a.OceanName,
              new Ocean
               {
                   OceanName = "Pacific Ocean",
                   AverageTemp = 86
               },
               new Ocean
               {
                   OceanName = "Atlantic Ocean",
                   AverageTemp = 57
               },
               new Ocean
               {
                   OceanName = "Indian Ocean",
                   AverageTemp = 77
               },
               new Ocean
               {
                   OceanName = "Artic Ocean",
                   AverageTemp = 31
               });

          

            // CREATE AQUATIC LIFE

            db.AquaticLifes.AddOrUpdate(
               a => a.AquaticLifeName,
              new AquaticLife
              {
                  Type = "Amphibian",
                  Color = "Black",
                  AquaticLifeName = "Poison Dart Frog",
                  IsInQuarantine = true
              },
              new AquaticLife
              {
                  Type = "Reptiles",
                  Color = "Brown",
                  AquaticLifeName = "African Pancake Tortoise",
                  IsInQuarantine = true
              },
               new AquaticLife
               {
                   Type = "Bony Fish",
                   Color = "Silver",
                   AquaticLifeName = "Banded Archerfish",
                   IsInQuarantine = false
               });


            //Data for OceanAquaticLife Table -so linking waht aquatic life is in each ocean
            //var indian = db.Oceans.First(f => f.OceanName == "Indian Ocean");
            //var pdf = db.AquaticLifes.First(f => f.AquaticLifeName == "Poison Dart Frog");
            //indian.AquaticLife.Add(pdf);

            //var atlantic = db.Oceans.First(f => f.OceanName == "Atlantic Ocean");
            //var aft = db.AquaticLifes.First(f => f.AquaticLifeName == "African Pancake Tortoise");
            //atlantic.AquaticLife.Add(aft);

            //var arctic = db.Oceans.First(f => f.OceanName == "Indian Ocean");
            //var ba = db.AquaticLifes.First(f => f.AquaticLifeName == "Banded Archerfish");
            //arctic.AquaticLife.Add(ba);


            //Data for AquaticLifeAquarium Table -so linking what aquatic life is in each aquarium
            //var GeorgiaPDF = db.Aquariums.First(f => f.AquariumName == "Georgia Aquarium");
            //var pdfGA = db.AquaticLifes.First(f => f.AquaticLifeName == "Poison Dart Frog");
            //GeorgiaPDF.AquaticLife.Add(pdfGA);

            //var GeorgiaAPT = db.Aquariums.First(f => f.AquariumName == "Georgia Aquarium");
            //var aftGA = db.AquaticLifes.First(f => f.AquaticLifeName == "African Pancake Tortoise");
            //GeorgiaAPT.AquaticLife.Add(aftGA);

            //var GeorgiaBA = db.Aquariums.First(f => f.AquariumName == "Georgia Aquarium");
            //var baGA = db.AquaticLifes.First(f => f.AquaticLifeName == "Banded Archerfish");
            //GeorgiaBA.AquaticLife.Add(baGA);

            //var Monterey = db.Aquariums.First(f => f.AquariumName == "Monterey Bay Aquarium");
            //var aftCA = db.AquaticLifes.First(f => f.AquaticLifeName == "African Pancake Tortoise");
            //Monterey.AquaticLife.Add(aftCA);

            //var National = db.Aquariums.First(f => f.AquariumName == "National Aquarium");
            //var baMD = db.AquaticLifes.First(f => f.AquaticLifeName == "Banded Archerfish");
            //National.AquaticLife.Add(baMD);

            //var NationalAFT = db.Aquariums.First(f => f.AquariumName == "National Aquarium");
            //var aftMD = db.AquaticLifes.First(f => f.AquaticLifeName == "African Pancake Tortoise");
            //NationalAFT.AquaticLife.Add(aftMD);


            db.SaveChanges();

            //A SQL Query that given an Aquarium Name, What AquaticLife is there
            //You should have to do a DB.aquariums.first(f => f.Name = "Atlanta").Aquaticlife


            var GAAquaticLife = db.Aquariums.First(f => f.AquariumName == "Georgia Aquarium").AquaticLife;

            foreach (var item in GAAquaticLife)
            {
                Console.WriteLine(item.AquaticLifeName);
            }


            //var GAAquaticLife = db.Aquariums.Where(f => f.AquariumName == "Georgia Aquarium").Select(s => s.AquaticLife.Aqu;

            //foreach (var item in GAAquaticLife)
            //{
            //    Console.WriteLine(item.AquaticLifeName);
            //}

            Console.WriteLine("Hello");
        }
    }
}
