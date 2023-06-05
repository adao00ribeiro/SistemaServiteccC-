using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using SistemaServitec.Data.Map;
using SistemaServitec.Models;
using System.Configuration;
using System.Windows.Forms;


namespace SistemaServitec.Data
{
    public class SistemaServitecDBContex : DbContext
    {

        public DbSet<PersonModel> Persons { get; set; }
        public DbSet<AddressModel> Addresss { get; set; }
        public DbSet<IdentityModel> Identitys { get; set; }
        public DbSet<LeaseContractModel> Contracts { get; set; }
        public DbSet<UserModel> Users { get; set; }


        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
        {
            base.OnConfiguring ( optionsBuilder );

            optionsBuilder.UseSqlite (
                ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString
            );
        
        }
       
        protected override void OnModelCreating ( ModelBuilder modelBuilder )
        {

            modelBuilder.ApplyConfiguration ( new PersonMap ( ) );
            modelBuilder.ApplyConfiguration ( new AddressMap ( ) );
            modelBuilder.ApplyConfiguration ( new IdentityMap ( ) );
            modelBuilder.ApplyConfiguration ( new LeaseContractMap ( ) );
            modelBuilder.ApplyConfiguration ( new UserMap ( ) );
            base.OnModelCreating ( modelBuilder );

           
        }

      
    }

}
