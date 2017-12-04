using System;
using System.Collections.Generic;
using System.Text;

namespace TypeCreationExamples2
{
    public class Product
    {
        public decimal Price { get; set; }
    }

    public static class MyExtensions
    {
        /*
            Here we write extension for Product, keyword 'this' makes this method as an extension method
         */
        public static decimal Discount(this Product product)
        {
            return product.Price * .9M;
        }
    }

    public class Calculator
    {
        public decimal CalculateDiscount(Product product)
        {
            return product.Discount();//usage of extension methods
        }
    }
}
