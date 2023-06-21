using eproject_sem3.Models;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eproject_sem3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}
        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }    
        public DbSet<Services> services { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<ServicesDetail> servicesDetail { get; set; }
        public  DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> ordersDetail { get; set; }
        public DbSet<Carts> carts { get; set; }
       

    }
}