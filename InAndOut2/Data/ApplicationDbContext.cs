using InAndOut2.Models;
using Microsoft.EntityFrameworkCore;

namespace InAndOut2.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
    }
}
