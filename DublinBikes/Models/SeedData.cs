using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DublinBikes.Data;
using System;
using System.Linq;

namespace DublinBikes.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DublinBikesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DublinBikesContext>>()))
            {
                // Look for any bikes.
                if (context.Bike.Any())
                {
                    return;   // DB has been seeded
                }

                context.Bike.AddRange(
                    new Bike
                    {
                        Number = 42,
                        ContractName = "Dublin",
                        Name = "SMITHFIELD NORTH",
                        Address = "Smithfield North",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"
                    },

                    new Bike
                    {
                        Number = 4,
                        ContractName = "Irish",
                        Name = "SMITH",
                        Address = "Sorth",
                        Latitude = 55.349,
                        Longitude = -6.278,
                        Banking = false,
                        AvailableBikes = 23,
                        AvailableStands = 4,
                        Capacity = 35,
                        Status = "CLOSE",
                        Rating = "A"
                    },

                    new Bike
                    {
                        Number = 30,
                        ContractName = "Dublin",
                        Name = "PARNELL SQUARE NORTH",
                        Address = "Parnell Square North",
                        Latitude = 53.353462,
                        Longitude = -6.265305,
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"
                    },

                    new Bike
                    {
                        Number = 54,
                        ContractName = "Dublin",
                        Name = "CLONMEL STREET",
                        Address = "Clonmel Street",
                        Latitude = 53.330621,
                        Longitude = -6.276142,
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"
                    },

                    new Bike
                    {
                        Number = 108,
                        ContractName = "Dublin",
                        Name = "AVONDALE ROAD",
                        Address = "Avondale Road",
                        Latitude = 53.359405,
                        Longitude = -6.276142,
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}