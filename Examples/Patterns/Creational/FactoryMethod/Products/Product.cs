using System;

namespace Patterns.Creational.FactoryMethod.Products
{
    public abstract class Product
    {
        public Guid Id { get; set; }
        public ProductTypeEnum Type { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Type: {Type}\nName: {Name}\nPrice - {Price}$";
        }
    }
}
