using System.Collections.Generic;
namespace PaymentContex.Domain.Entities
{
    public class Student
    {
        public string FirsName {get; set; }
        public string LastName {get; set; }
        public string Document {get; set; }
        public string Email {get; set; }
        public List<Subscription> Subscriptions {get; set;}
        public string Address {get; set;}

    }
}