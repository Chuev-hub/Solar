using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Solar.DAL.Context
{
    public class SiteContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Guitar> Guitars { get; set; }
        public DbSet<GuitarCategory> GuitarCategories { get; set; }
        public DbSet<ImageSite> ImagesSite { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductOrder> ProductsOrder { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<UsersBasket> UsersBaskets { get; set; }

        public SiteContext() : base("name=CodeFirstCS")
        {

        }

    }
}
