using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynCart
{
    /// <summary>
    /// CustomerDetails class holdes the information about Customers<see cref="CustomerDetails"/>
    /// </summary> 
    public class CustomerDetails
    {
        /// <summary>
        /// CustomerID is used to store and get customer id <see cref="CustomerDetails"/>
        /// </summary> 
        public string CustomerID{get;set;}
        /// <summary>
        /// Name is used to store and get customer Name <see cref="CustomerDetails"/>
        /// </summary> 
        public string Name{get;set;}
        /// <summary>
        /// City is used to store and get customer City <see cref="CustomerDetails"/>
        /// </summary> 
        public string City{get;set;}
        /// <summary>
        /// WalletBalance is used to store and get customer WalletBalance <see cref="CustomerDetails"/>
        /// </summary> 
        public int WalletBalance{get;set;}
        /// <summary>
        /// PhoneNumber is used to store and get customer PhoneNumber <see cref="CustomerDetails"/>
        /// </summary> 
        public int PhoneNumber{get;set;}
        /// <summary>
        /// EmailID is used to store and get customer EmailID <see cref="CustomerDetails"/>
        /// </summary> 
        public string EmailID{get;set;}
        /// <summary>
        /// WalletRecharge method is used to add amount to customers balance<see cref="CustomerDetails"/>
        /// </summary>
        /// <param name="amount">amount is the value need to be added</param> 
        public void WalletRecharge(int amount)
        {
            WalletBalance=WalletBalance+amount;
        }
        /// <summary>
        /// WalletRecharge method is used to Deduct amount from customers balance<see cref="CustomerDetails"/>
        /// </summary>
        /// <param name="amount">amount is the value need to be Deduct</param> 
        public void DeductBalance(int amount)
        {
            WalletBalance=WalletBalance-amount;
        }
    }
}