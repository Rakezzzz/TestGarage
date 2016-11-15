namespace TestGarage.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TestGarage.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TestGarage.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TestGarage.Models.ApplicationDbContext context)
        {

            //Person p1 = new Person() { SSN = "80", Name = "Sigge" };
            //Person p2 = new Person() { SSN = "8", Name = "Aps" };
            //Person p3 = new Person() { SSN = "3", Name = "Emil" };



            //Vehicle v1 = new Vehicle() { RegNum = "CCC", Owner = p1 };
            //Vehicle v2 = new Vehicle() { RegNum = "BBDDDB", Owner = p2 };
            //Vehicle v3 = new Vehicle() { RegNum = "CCC", Owner = p2 };
            //Vehicle v4 = new Vehicle() { RegNum = "DDD", Owner = p1 };
            //Vehicle v5 = new Vehicle() { RegNum = "EEE", Owner = p1 };
            //Vehicle v6 = new Vehicle() { RegNum = "FFF", Owner = p1 };


            //Parkingspot ps1 = new Parkingspot() { ParkId = 1, ParkedVehicle = v1, Renter = p1 };
            //Parkingspot ps2 = new Parkingspot() { ParkId = 2, ParkedVehicle = v2, Renter = p2 };
            //Parkingspot ps3 = new Parkingspot() { ParkId = 3, ParkedVehicle = v3, Renter = p2 };
            //Parkingspot ps4 = new Parkingspot() { ParkId = 4, ParkedVehicle = v4, Renter = p2 };
            //Parkingspot ps5 = new Parkingspot() { ParkId = 5, ParkedVehicle = v5, Renter = p3 };
            //Parkingspot ps6 = new Parkingspot() { ParkId = 6, ParkedVehicle = v6, Renter = p3 };




            context.Parkingspots.AddOrUpdate(
                park => park.ParkId,
                    new Parkingspot() { ParkId = 1, RegNum = "BBDDDB", SSN = "8" }
                );







            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
