using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolMVC.Models
{
    public class Course
    {
        [Key]
        public int CRS_ID { get; set; }
        public string Name { get; set; }

        [ForeignKey("Teacher")]
        public int id { get; set; }
        public virtual Teacher teacher { get; set; }

    }
}