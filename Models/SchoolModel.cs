using System;
using System.Data.Entity;
using System.Linq;

namespace SchoolMVC.Models
{
    public class SchoolModel : DbContext
    {
    
        public SchoolModel()
            : base("name=SchoolModel")
        {
        }

     
         public virtual DbSet<Student> Students { get; set; }
         public virtual DbSet<Teacher> Teachers { get; set; }
         public virtual DbSet<Course> Courses { get; set; }
         public virtual DbSet<ClassRoom> ClassRooms { get; set; }
    }

   
}