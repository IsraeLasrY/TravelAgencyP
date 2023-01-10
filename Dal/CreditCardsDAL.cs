using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TravelAgencyP.Models
{
    public partial class CreditCardsDAL : DbContext
    {
        public CreditCardsDAL()
             : base("data source=ISRAELASRY;initial catalog=tempdb;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
             //: base("Data Source=YAM;Initial Catalog=tempdb;Integrated Security=True")
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

            modelBuilder.Entity<CreditCard>()
                .Property(e => e.ID)
                .IsUnicode(false);
        }
    }
}
