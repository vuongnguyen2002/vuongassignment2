using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Assignment2.Models
{
    public partial class DBcontext : DbContext
    {
        public DBcontext()
            : base("name=DBcontext")
        {
        }

        public virtual DbSet<Lecture> Lectures { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
