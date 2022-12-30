namespace TravelAgencyP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdminInfo")]
    public partial class AdminInfo
    {
        [Required]
        [StringLength(50)]
        public string AdminEmail { get; set; }

        [Key]
        [StringLength(50)]
        public string AdminPassword { get; set; }
    }
}
