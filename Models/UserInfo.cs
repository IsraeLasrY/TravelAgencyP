namespace TravelAgencyP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserInfo")]
    public partial class UserInfo
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string UserEmail { get; set; }

        [StringLength(50)]
        public string UserPassword { get; set; }
    }
}
