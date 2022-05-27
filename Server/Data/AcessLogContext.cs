using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Data
{
    public class AcessLogContext : DbContext
    {

        public DbSet<AcessLogContext> AcessLogContexts { get; set; } = default!;
        public AcessLogContext(DbContextOptions<AcessLogContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Server=localhost,1433;Database=MyDatabase;User Id=sa;Password=Database!2022;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Database>().HasKey(p => p.Id);
        }
        //public class BloggingContextFactory : IDesignTimeDbContextFactory<BloggingContext>
        //{
        //    public AcessLogContext CreateDbContext(string[] args)
        //    {
        //        var optionsBuilder = new DbContextOptionsBuilder<BloggingContext>();
        //        optionsBuilder.UseSqlServer("Data Source=blog.db");

        //        return new BloggingContext(optionsBuilder.Options);
        //    }
        //}


    }
}
