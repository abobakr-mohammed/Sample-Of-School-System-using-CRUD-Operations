﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolMVC.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int age { get; set; }

        [ForeignKey("ClassRoom")]
        public int ID { get; set; }
        public virtual ClassRoom classroom  { get; set; }

    
       

    }
}