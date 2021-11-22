namespace Assignment2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lecture")]
    public partial class Lecture
    {
        [Key]
        public long StudentID { get; set; }

        [Required]
        [StringLength(200)]
        public string LectureName { get; set; }
    }
}
