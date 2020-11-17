using System;
using System.Collections.Generic;

namespace PaymentContex.Domain.Entities{

    public class Subscription
    {
        public DateTime CreateData {get; set; }
        public DateTime LastUpDate {get; set; }
        public DateTime? ExpireData {get; set; }
        public  bool Active{ get; set;}
        public List<Payment> Payments {get; set; }
    }
}   