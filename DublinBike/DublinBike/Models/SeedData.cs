using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DublinBike.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DublinBike.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcBikeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcBikeContext>>()))
            {

                if (context.Bike.Any())
                {
                    return;
                }

                context.Bike.AddRange(
                    new DublinStation
                    {
                        Number = 42,
                        Name = "SMITHFIELD NORTH",
                        adress = "Smithfield North",
                        latitude = 53.349562,
                        longitude = -6.278198
                    },

                    new DublinStation
                    {
                        Number = 30,
                        Name = "PARNELL SQUARE NORTH",
                        adress = "Parnell Square North",
                        latitude = 53.353462,
                        longitude = -6.265305
                    },

                    new DublinStation
                    {
                        Number = 54,
                        Name = "CLONMEL STREET",
                        adress = "Clonmel Street",
                        latitude = 53.330621,
                        longitude = -6.276142
                    },

                    new DublinStation
                    {
                        Number = 108,
                        Name = "AVONDALE ROAD",
                        adress = "Avondale Road",
                        latitude = 53.359405,
                        longitude = -6.276142
                    },

                    new DublinStation
                    {
                        Number = 56,
                        Name = "MOUNT STREET LOWER",
                        adress = "Mount Street Lower",
                        latitude = 53.33796,
                        longitude = -6.24153
                    },

                    new DublinStation
                    {
                        Number = 6,
                        Name = "CHRISTCHURCH PLACE",
                        adress = "Christchurch place",
                        latitude = 53.343368,
                        longitude = -6.27012
                    },

                    new DublinStation
                    {
                        Number = 18,
                        Name = "GRANTHAM STREET",
                        adress = "Grantham Street",
                        latitude = 53.334123,
                        longitude = -6.265436
                    },

                    new DublinStation
                    {
                        Number = 42,
                        Name = "PEARSE STREET",
                        adress = "Pearse Street",
                        latitude = 53.344304,
                        longitude = -6.250427
                    },

                    new DublinStation
                    {
                        Number = 52,
                        Name = "YORK STREET EAST",
                        adress = "York Street East",
                        latitude = 53.338755,
                        longitude = -6.262003
                    },

                    new DublinStation
                    {
                        Number = 48,
                        Name = "EXCISE WALK",
                        adress = "Smithfield North",
                        latitude = 53.347777,
                        longitude = -6.244239
                    },

                    new DublinStation
                    {
                        Number = 13,
                        Name = "FITZWILLIAM SQUARE WEST",
                        adress = "Fitzwilliam Square West",
                        latitude = 53.336074,
                        longitude = -6.252825
                    },

                    new DublinStation
                    {
                        Number = 43,
                        Name = "PORTOBELLO ROAD",
                        adress = "Portobello Road",
                        latitude = 53.330091,
                        longitude = -6.268044
                    },

                    new DublinStation
                    {
                        Number = 81,
                        Name = "ST. JAMES HOSPITAL (CENTRAL)",
                        adress = "St. James Hospital (central)",
                        latitude = 53.339983,
                        longitude = -6.295594
                    },

                    new DublinStation
                    {
                        Number = 31,
                        Name = "PARNEL STREET",
                        adress = "Parnel Street",
                        latitude = 53.350929,
                        longitude = -6.265125
                    },

                    new DublinStation
                    {
                        Number = 98,
                        Name = "FREDERIC STREET SOUTH",
                        adress = "Frederic Street South",
                        latitude = 53.341515,
                        longitude = -6.256853
                    },

                    new DublinStation
                    {
                        Number = 23,
                        Name = "CUSTOM HOUSE",
                        adress = "Custom House",
                        latitude = 53.348279,
                        longitude = -6.254662
                    },

                    new DublinStation
                    {
                        Number = 106,
                        Name = "RATHDOWN ROAD",
                        adress = "Rathdown Road",
                        latitude = 53.35893,
                        longitude = -6.280337
                    },

                    new DublinStation
                    {
                        Number = 112,
                        Name = "NORTH CIRCULAR ROAD (O'CONNELL'S)",
                        adress = "North Circular Road (O'Connell's)",
                        latitude = 53.357841,
                        longitude = -6.251557
                    },
                    new DublinStation
                    {
                        Number = 68,
                        Name = "HANOVER QUAY",
                        adress = "Hanover Quay",
                        latitude = 53.344115,
                        longitude = -6.237153

                    },



                    new DublinStation
                    {
                        Number = 74,
                        Name = "OLIVER BOND STREET",
                        adress = "Oliver Bond Street",
                        latitude = 53.34893,
                        longitude = -6.280531

                    },

                    new DublinStation
                    {
                        Number = 87,
                        Name = "COLLINS BARRACKS MUSEUM",
                        adress = "Collins Barracks Museum",
                        latitude = 53.347477,
                        longitude = -6.28525

                    },

                    new DublinStation
                    {
                        Number = 84,
                        Name = "BROAKFIELD ROAD",
                        adress = "Broakfield Road",
                        latitude = 53.339005,
                        longitude = -6.300217

                    },

                    new DublinStation
                    {
                        Number = 90,
                        Name = "BENSEN STREET",
                        adress = "Bensen Street",
                        latitude = 53.344153,
                        longitude = -6.323451

                    },

                    new DublinStation
                    {
                        Number = 11,
                        Name = "EARLSFORT TERRACE",
                        adress = "Eearlsfoer Terrace",
                        latitude = 53.344019,
                        longitude = -6.258371
                    }
                    ) ;
                context.SaveChanges();
            }
        }
    }
}