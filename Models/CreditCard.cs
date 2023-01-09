namespace TravelAgencyP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditCard")]
    public partial class CreditCard
    {
        [Required]
        [StringLength(50)]
        public string NameOnCard { get; set; }

        [Key]
        [StringLength(50)]
        public string CardNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpirationDate { get; set; }

        [StringLength(50)]
        public string ID { get; set; }

    }
}
