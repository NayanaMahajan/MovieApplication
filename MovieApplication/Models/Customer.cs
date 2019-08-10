using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieApplication.Models
{
    public class Customer
    { 
        [Display(Name = "Customer Id")]
        public int Id { get; set; }

        [Display(Name ="Customer Name")]
        public string Name { get; set; }
        public string City { get; set; }
        public string MovieName { get; set; }
        public string Gender { get; set; }
    }
}