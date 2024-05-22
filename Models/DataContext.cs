using Doan.Areas.Admin.Models;
using Doan.Controllers;
using Doan.Models;
using Microsoft.EntityFrameworkCore;

namespace Doan.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 

        }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Slide> Slide { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<NewArrivals> NewArrivals{ get; set;}
        public DbSet<Dealoftheweek> Dealoftheweek { get; set; }
        public DbSet<AdminMenu> AdminMenu { get; set; }
        public DbSet<Benefit> Benefit { get; set; }
        public DbSet<Footer> Footer { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Product_size> Product_size {  get; set; }    
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Pay_method> Pay_method { get; set; }
    }
}
