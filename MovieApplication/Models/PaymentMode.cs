﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieApplication.Models
{
    public class PaymentMode
    {
       public int Id { get; set; }
        public string PaymentType { get; set; }
    }
}