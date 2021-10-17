using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MoviesAPI.Models.DTOs.Requests;


namespace MoviesAPI.Data
{
    //dengan mewarisi dari IdentityDbContext pada DbContext, EntityFramework akan tahu bahwa kita menggunakan otentikasi dan itu akan menggunakan tabel default identity
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<MovieData> Movie { get; set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base (options)
        {
            
        } 
    }
}