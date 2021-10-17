using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;
using MySql.EntityFrameworkCore.Extensions;


namespace MoviesAPI.Data
{
    //dengan mewarisi dari IdentityDbContext pada DbContext, EntityFramework akan tahu bahwa kita menggunakan otentikasi dan itu akan menggunakan tabel default identity
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<MovieData> Items { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("DefaultConnection");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MovieData>(entity =>
            {
                entity.HasKey(e => e.Id);
                //entity.Property(e => e.Name).IsRequired();
            });

        }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base (options)
        {
            
        } 
    }
}