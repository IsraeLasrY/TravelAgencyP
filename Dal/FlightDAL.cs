using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using TravelAgencyP.Models;

namespace TravelAgencyP.Dal
{
    public partial class FlightDAL : DbContext
    {
        public FlightDAL()
             //: base("data source=ISRAELASRY;initial catalog=tempdb;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
             : base("Data Source=YAM;Initial Catalog=tempdb;Integrated Security=True")
        {
        }

        public virtual DbSet<FlightsInfo> FlightsInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlightsInfo>()
                .Property(e => e.FlightNumber)
                .IsUnicode(false);

            modelBuilder.Entity<FlightsInfo>()
                .Property(e => e.AirLine)
                .IsUnicode(false);

            modelBuilder.Entity<FlightsInfo>()
                .Property(e => e.Terminal)
                .IsUnicode(false);

            modelBuilder.Entity<FlightsInfo>()
                .Property(e => e.DestinationFlight)
                .IsUnicode(false);

            modelBuilder.Entity<FlightsInfo>()
                .Property(e => e.OriginFlight)
                .IsUnicode(false);
        }
    }
}
