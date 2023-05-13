using Microsoft.EntityFrameworkCore;
using SistemaServitec.Data.Map;
using SistemaServitec.Models;
using System.Configuration;

namespace SistemaServitec.Data
{
    public class SistemaServitecDBContex: DbContext
    {
     
        public DbSet<PersonModel> Persons { get; set; }
        public DbSet<AddressModel> Addresss { get; set; }
        public DbSet<IdentityModel> Identitys { get; set; }
        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
        {
            base.OnConfiguring ( optionsBuilder );

            optionsBuilder.UseSqlite (
                ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString
            );
                
        }
        protected override void OnModelCreating ( ModelBuilder modelBuilder )
        {
            modelBuilder.ApplyConfiguration (new PersonMap());
            modelBuilder.ApplyConfiguration (new AddressMap());
            modelBuilder.ApplyConfiguration (new IdentityMap());

            base.OnModelCreating ( modelBuilder );
        }
    }
}
