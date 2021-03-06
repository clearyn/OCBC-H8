using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TodoAppWithJWT.Models
{
    public class ItemData
    {
        public int Id{ get; set;}
        public string Title { get; set; }
        public string Description { get; set;}
        public bool Done { get; set;}
    }
}