using Microsoft.EntityFrameworkCore;
using goatvote.api.Models;

namespace goatvote.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<Player> Players { get; set; }
    }
}