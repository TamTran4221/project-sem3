using eproject_sem3.Models;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eproject_sem3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }    
        public DbSet<Services> Services { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<ServicesDetail> ServicesDetail { get; set; }
        public  DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrdersDetail { get; set; }
        public DbSet<Carts> Carts { get; set; }
       

    }
}