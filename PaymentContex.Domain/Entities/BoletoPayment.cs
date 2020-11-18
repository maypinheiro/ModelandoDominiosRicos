
using System;
using PaymentContex.Domain.Entities;

public  class boletoPayment : Payment 
    {
    public boletoPayment(string barCode, string boletoNumber,
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
        BarCode = barCode;
        BoletoNumber = boletoNumber;
    }

    public string BarCode {get;  private set;}
        public string BoletoNumber {get; private set;}
        
    }