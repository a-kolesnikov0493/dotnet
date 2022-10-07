using System;

namespace Patterns.Structural.Bridge
{
    public abstract class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
