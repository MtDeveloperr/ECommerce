using ECommerce.Discount.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ECommerce.Discount.Context
{
    public class DapperContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;


        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        public DbSet<Coupon> Coupon{ get; set; }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
        //baslatılan proje basta Discount seciliyo sonra package manager konsole acılıyo oıradan da discount seciliyo
        //sonra add-migration mig1 sonra da enter de build sonucu bekle sonra success gelirse update-database de
    }
}
