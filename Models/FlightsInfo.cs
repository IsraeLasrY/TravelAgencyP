namespace TravelAgencyP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FlightsInfo")]
    public partial class FlightsInfo
    {
        [Key]
        [StringLength(50)]
        public string FlightNumber { get; set; }

        [StringLength(50)]
        public string AirLine { get; set; }

        [StringLength(2)]
        public string Terminal { get; set; }

        [StringLength(50)]
        public string DestinationF { get; set; }

        [StringLength(50)]
        public string OriginF { get; set; }

        [Column(TypeName = "date")]
        public DateTime DepDateF { get; set; }

        [Column(TypeName = "date")]
        public DateTime LandDateF { get; set; }

        public TimeSpan DepT { get; set; }

        public TimeSpan LandT { get; set; }

        public int? Seats { get; set; }

        public int? PriceTicket { get; set; }

        [StringLength(50)]
        public string RoundTrip { get; set; }
    }
}
