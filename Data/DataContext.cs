using BACK-DSV.Models;
using Microsoft.EntityFrameworkCore;

namespace BACK-DSV.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Produto> Movies { get; set; }

        // override OnModelCreating()

    }
}