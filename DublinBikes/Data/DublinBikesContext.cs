using Microsoft.EntityFrameworkCore;
using DublinBikes.Models;

namespace DublinBikes.Data
{
    public class DublinBikesContext : DbContext
    {
        public DublinBikesContext(DbContextOptions<DublinBikesContext> options)
            : base(options)
        {
        }

        public DbSet<Bike> Bike { get; set; }
    }
}