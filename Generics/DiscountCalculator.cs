using System;

namespace Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price * 1.10f;
        }
    }
    
    public class Product
    {
        public string TItle { get; set; }
        public float Price { get; set; }
    }
    public class Book : Product
    {
        public string Isbn { get; set; }
    }
}
