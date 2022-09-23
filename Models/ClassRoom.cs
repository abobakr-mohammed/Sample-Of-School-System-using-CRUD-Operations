using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolMVC.Models
{
    public class ClassRoom
    {
        
        public int id { get; set; }
        public string name { get; set; }

        public virtual HashSet<Student> Students { get; set; }
           = new HashSet<Student>();
       
    }
}