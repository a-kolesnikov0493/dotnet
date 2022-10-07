using Patterns.Creational.AbstractFactory.Products.ConcreteProduct.Interfaces.Styles;
using Patterns.Creational.AbstractFactory.Products.ConcreteProduct.Interfaces.Types;
using System;

namespace Patterns.Creational.AbstractFactory.Products.ConcreteProduct.ArDeco
{
    public class ArDecoChair : Chair, IArDecoProduct
    {
        public ArDecoChair(Guid id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override ProductStyleType Style => ProductStyleType.ArDeco;
    }
}
