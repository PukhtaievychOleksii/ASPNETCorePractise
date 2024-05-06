using Domain.SharedResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; } = string.Empty;

        public Money Price { get; private set; }

      
       
        public SKU Sku { get; private set; }
    }


   
    public struct SKU
    {
        public const int DefaultLength = 10;
        private SKU(string value) => Value = value;
        public string Value { get; }

        public static SKU? Create(string value)
        {
            if (value.Length != DefaultLength || string.IsNullOrEmpty(value)) return null;
            return new SKU(value);
        }

    }

}