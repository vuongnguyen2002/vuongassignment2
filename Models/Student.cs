namespace Assignment2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long StudentID { get; set; }

        [StringLength(200)]
        public string StudentName { get; set; }

        [StringLength(200)]
        public string StudentEmail { get; set; }

        public bool Gender { get; set; }

        public long LectureID { get; set; }

        [StringLength(200)]
        public string LectureName { get; set; }
    }
}
