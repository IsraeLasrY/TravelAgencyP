using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using TravelAgencyP.Models;

namespace TravelAgencyP.Dal
{
    public partial class AdminDAL : DbContext
    {
        public AdminDAL()
            : base("data source=ISRAELASRY;initial catalog=tempdb;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public virtual DbSet<AdminInfo> AdminInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminInfo>()
                .Property(e => e.AdminEmail)
                .IsUnicode(false);

            modelBuilder.Entity<AdminInfo>()
                .Property(e => e.AdminPassword)
                .IsUnicode(false);
        }
    }
}
