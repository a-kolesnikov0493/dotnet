using System;

namespace Patterns.Creational.AbstractFactory.Products
{
    public abstract class Product : IProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public abstract ProductType Type { get; }
        public abstract ProductStyleType Style { get; }
    }
}
