using System.Data;
using System;
using System.Collections.Generic;

namespace PaymentContex.Domain.Entities{

    public class Subscription
    {

        private IList<Payment> _playments;
            public Subscription( DateTime? expireData)        {
            CreateData = DateTime.Now;
            LastUpDate = DateTime.Now;
            ExpireData = expireData;
            Active = true;
            _playments= new List<Payment>();
        }

        public DateTime CreateData {get; private set; }
        public DateTime LastUpDate {get; private set; }
        public DateTime? ExpireData {get; private set; }
        public  bool Active{ get; private set;}
        public IReadOnlyCollection<Payment> Payments {get; private set; }

        public void AddPayment(Payment payment){
            _playments.Add(payment);

        }

        public void Activate(){
            Active = true;
            LastUpDate= DateTime.Now;
        }
        public void Inactivate(){
            Active = false;
            LastUpDate= DateTime.Now;
        }
    }
}   