using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models
{
    public class ItemData
    {   
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}