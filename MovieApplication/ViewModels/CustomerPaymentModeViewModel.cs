using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieApplication.Models;

namespace MovieApplication.ViewModels
{
    public class CustomerPaymentModeViewModel
    {
        public IEnumerable<PaymentMode> paymentMode { get; set; }
        public Customer customer { get; set; }
    }
}