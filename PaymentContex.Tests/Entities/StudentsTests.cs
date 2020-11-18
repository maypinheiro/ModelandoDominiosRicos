
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContex.Domain.Entities;

namespace PaymentContex.Tests{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var subscription= new Subscription(null);
            var student = new Student("Mayara","Pinheiro","123456789","mayarapinheirodesousa@hotmail.com");
            student.AddSubscriptions(subscription);
            

        }
    }
}