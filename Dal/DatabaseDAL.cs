using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TravelAgencyP.Dal
{
    public partial class DatabaseDAL : DbContext
    {
        public DatabaseDAL()
            : base("name=DatabaseDAL")
        {
        }

        public virtual DbSet<CreditCard> CreditCard { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CreditCard>()
                .Property(e => e.NameOnCard)
                .IsUnicode(false);

            modelBuilder.Entity<CreditCard>()
                .Property(e => e.CardNumber)
                .IsUnicode(false);
        }
    }
}
