using System;
using PaymentContex.Domain.Entities;

public class PlayPalPayment : Payment 
    {
    public PlayPalPayment(
        string transactionCode,
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
        TransactionCode = transactionCode;
    }

    public string TransactionCode {get; private set;}
    }