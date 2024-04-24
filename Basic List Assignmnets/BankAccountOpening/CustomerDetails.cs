using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccountOpening
{
    public enum Gender{select,Male,Female}
    /// <summary>
    /// this class performs an input
    /// </summary>
    public class CustomerDetails
    {
        public string CustomerId{get;set;}
        public string CustomerName{get;set;}
        public int Balance{get;set;}
        public Gender Gender{get;set;}
        public string Phone{get;set;}
        public string MailId{get;set;}
        public DateTime Dob{get;set;}

        public void Deposit()
        {
            Console.WriteLine("Enter the amount to deposit : ");
            int amount=int.Parse(Console.ReadLine());
            Balance=amount+Balance;
            Console.WriteLine("Total Balance : "+Balance);
        }
        public void Withdraw()
        {
            Console.WriteLine("Enter the amount to withdraw : ");
            int amount=int.Parse(Console.ReadLine());
            if(amount>Balance)
            {
                Console.WriteLine("Insufficent Balance");
            }
            else
            {
                Balance=Balance-amount;
                Console.WriteLine("Total Balance : "+Balance);
            }
        }
        
    }
}