using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynCart
{
    /// <summary>
    /// ProductDetails class holdes ProductDetails <see cref="ProductDetails"/>
    /// </summary>
    public class ProductDetails
    {
        /// <summary>
        /// ProductID is used to store and get Product id <see cref="ProductDetails"/>
        /// </summary> 
        public string ProductID{get;set;}
        /// <summary>
        /// ProductName is used to store and get Product Name <see cref="ProductDetails"/>
        /// </summary> 
        public string ProductName{get;set;}
        /// <summary>
        /// Price is used to store and get Product Price <see cref="ProductDetails"/>
        /// </summary> 
        public int Price{get;set;}
        /// <summary>
        /// Stock is used to store and get Product Stock count <see cref="ProductDetails"/>
        /// </summary> 
        public int Stock{get;set;}
        /// <summary>
        /// ShippingDuration is used to store and get product Shipping Duration <see cref="ProductDetails"/>
        /// </summary> 
        public int ShippingDuration{get;set;}
    }
}