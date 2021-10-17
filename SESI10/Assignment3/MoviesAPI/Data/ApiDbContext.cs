using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MoviesAPI.Models.DTOs.Requests;


namespace MoviesAPI.Data
{
    //dengan mewarisi dari IdentityDbContext pada DbContext, EntityFramework akan tahu bahwa kita menggunakan otentikasi dan itu akan menggunakan tabel default identity
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<ItemData> Items { get; set;}

        // protected override void OnModelCreating(ModelBuilder builder)
        // {   
        //     builder.Entity<ItemData>().HasData(
        //         new ItemData
        //         {   
        //             Id = 1,
        //             Name = "Bad Boys for Life",
        //             Genre = "Action/Comedy",
        //             Duration = "2h 5mins",
        //             ReleaseDate = System.DateTime.Today
        //         }
        //     );
        // }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base (options)
        {
            
        }
    }
}