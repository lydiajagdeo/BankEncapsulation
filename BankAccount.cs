using System;
namespace BankEncapsulation
{
    public class BankAccount
    {
        
           private double _balance = 0;

           public void Deposit( double money)
           { 
            _balance += money;
            
           }   

        public double GetBalance()
        {
            return _balance;
        }
        
    }
}

