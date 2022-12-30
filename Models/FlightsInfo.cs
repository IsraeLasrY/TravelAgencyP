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
        public string DestinationFlight { get; set; }

        [StringLength(50)]
        public string OriginFlight { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DepDateFlight { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LandDateFlight { get; set; }

        public int? Seats { get; set; }

        public int? PriceTicket { get; set; }

        public int? Rating { get; set; }
    }
}
