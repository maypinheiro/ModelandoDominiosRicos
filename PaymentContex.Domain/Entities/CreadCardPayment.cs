using System;
using PaymentContex.Domain.Entities;

public class CreditCardPayment : Payment 
    {
    public CreditCardPayment(
        string cardHolderName, 
        string cardNumber, 
        string lastTransactionNumber,  
        DateTime paidDate, 
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        string document,
        string payer,
        string address,
        string email): base(
             paidDate,
             expireDate,
             total,
             totalPaid,  
             document,  
             payer,  
             address,  
             email)
    {
        CardHolderName = cardHolderName;
        CardNumber = cardNumber;
        LastTransactionNumber = lastTransactionNumber;
    }

    public string CardHolderName {get; private set;}
        public string CardNumber{get; set;}
        public string LastTransactionNumber {get; set;}
    }
   