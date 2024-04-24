using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynCart
{
    /// <summary>
    /// OrderStatus is a public enum  which has following values{Default, Ordered, Cancelled}<see cref="OrderDetails"/>
    /// </summary> 
    public enum OrderStatus{Default, Ordered, Cancelled}
    /// <summary>
    /// OrderDetails class holdes the information about Order<see cref="OrderDetails"/>
    /// </summary> 
    public class OrderDetails
    {
        /// <summary>
        /// OrderID is used to store and get Order id <see cref="OrderDetails"/>
        /// </summary> 
        public string OrderID{get;set;}
        /// <summary>
        /// CustomerID is used to store and get customer id <see cref="OrderDetails"/>
        /// </summary> 
        public string CustomerID{get;set;}
        /// <summary>
        /// ProductID is used to store and get Product id <see cref="OrderDetails"/>
        /// </summary> 
        public string ProductID{get;set;}
        /// <summary>
        /// TotalPrice is used to store and get TotalPrice of the order <see cref="OrderDetails"/>
        /// </summary> 
        public int TotalPrice{get;set;}
        /// <summary>
        /// PurchaseDate is used to store and get PurchaseDate <see cref="OrderDetails"/>
        /// </summary> 
        public DateTime PurchaseDate{get;set;}
        /// <summary>
        /// Quantity is used to store and get Quantity of the product purchased <see cref="OrderDetails"/>
        /// </summary> 
        public int Quantity{get;set;}
        /// <summary>
        /// OrderStatus is used to store and get Order Status <see cref="OrderDetails"/>
        /// </summary> 
        public OrderStatus OrderStatus{get;set;}
    }
}