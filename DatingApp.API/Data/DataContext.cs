using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Value> Values { get; set; } // The name of these property is the name that the table will have
        public DbSet<User> Users{get;set;}
        public DbSet<Photo> Photos { get; set; }
    }
}