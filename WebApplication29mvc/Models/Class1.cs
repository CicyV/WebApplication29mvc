using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication29mvc.Models
{
    public class Class1
    {
        [Required]
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string msg { get; set; }
    }
}