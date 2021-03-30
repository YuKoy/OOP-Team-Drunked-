using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DublinBikes.Data;
using System;
using System.Linq;

//SeedData
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
                    },
                    new Bike
                    {
                        Number = 56,
                        Name = "MOUNT STREET LOWER",
                        Address = "Mount Street Lower",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"


                    },

                    new Bike
                    {
                        Number = 6,
                        Name = "CHRISTCHURCH PLACE",
                        Address = "Christchurch place",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"
                    },

                    new Bike
                    {
                        Number = 18,
                        Name = "GRANTHAM STREET",
                        Address = "Grantham Street",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"
                    },

                    new Bike
                    {
                        Number = 42,
                        Name = "PEARSE STREET",
                        Address = "Pearse Street",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"
                    },

                    new Bike
                    {
                        Number = 52,
                        Name = "YORK STREET EAST",
                        Address = "York Street East",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"
                    },

                    new Bike
                    {
                        Number = 48,
                        Name = "EXCISE WALK",
                        Address = "Smithfield North",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"
                    },

                    new Bike
                    {
                        Number = 13,
                        Name = "FITZWILLIAM SQUARE WEST",
                        Address = "Fitzwilliam Square West",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"
                    },

                    new Bike
                    {
                        Number = 43,
                        Name = "PORTOBELLO ROAD",
                        Address = "Portobello Road",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"
                    },

                    new Bike
                    {
                        Number = 81,
                        Name = "ST. JAMES HOSPITAL (CENTRAL)",
                        Address = "St. James Hospital (central)",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"
                    },

                    new Bike
                    {
                        Number = 31,
                        Name = "PARNEL STREET",
                        Address = "Parnel Street",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"
                    },

                    new Bike
                    {
                        Number = 98,
                        Name = "FREDERIC STREET SOUTH",
                        Address = "Frederic Street South",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"
                    },

                    new Bike
                    {
                        Number = 23,
                        Name = "CUSTOM HOUSE",
                        Address = "Custom House",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"
                    },

                    new Bike
                    {
                        Number = 106,
                        Name = "RATHDOWN ROAD",
                        Address = "Rathdown Road",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"
                    },

                    new Bike
                    {
                        Number = 112,
                        Name = "NORTH CIRCULAR ROAD (O'CONNELL'S)",
                        Address = "North Circular Road (O'Connell's)",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"
                    },
                    new Bike
                    {
                        Number = 68,
                        Name = "HANOVER QUAY",
                        Address = "Hanover Quay",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"

                    },

                    new Bike
                    {
                        Number = 74,
                        Name = "OLIVER BOND STREET",
                        Address = "Oliver Bond Street",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"

                    },

                    new Bike
                    {
                        Number = 87,
                        Name = "COLLINS BARRACKS MUSEUM",
                        Address = "Collins Barracks Museum",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"

                    },

                    new Bike
                    {
                        Number = 84,
                        Name = "BROAKFIELD ROAD",
                        Address = "Broakfield Road",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"

                    },

                    new Bike
                    {
                        Number = 90,
                        Name = "BENSEN STREET",
                        Address = "Bensen Street",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
                        Banking = true,
                        AvailableBikes = 30,
                        AvailableStands = 5,
                        Capacity = 35,
                        Status = "OPEN",
                        Rating = "R"

                    },

                    new Bike
                    {
                        Number = 11,
                        Name = "EARLSFORT TERRACE",
                        Address = "Eearlsfoer Terrace",
                        Latitude = 53.349562,
                        Longitude = -6.278198,
                        ContractName = "Dublin",
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