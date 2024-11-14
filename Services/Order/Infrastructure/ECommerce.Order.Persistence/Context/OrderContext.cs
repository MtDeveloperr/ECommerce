using ECommerce.Order.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Persistence.Context
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=...;initial Catalog=ECommerceOrderDb;integrated Security=true;");
        }
        public DbSet<Address> Address { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Ordering> Ordering { get; set; }
    }
}
