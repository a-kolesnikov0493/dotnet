using Patterns.Creational.AbstractFactory.Products.ConcreteProduct.ArDeco;
using Patterns.Creational.AbstractFactory.Products.ConcreteProduct.Interfaces.Styles;
using Patterns.Creational.AbstractFactory.Products.ConcreteProduct.Modern;
using Patterns.Creational.AbstractFactory.Products.ConcreteProduct.Victorian;
using System;

namespace Patterns.Creational.AbstractFactory.Factories
{
    public class SofaFactory : IAbstractFactory
    {
        public IArDecoProduct CreateArDecoProduct(Guid id, string name, decimal price)
        {
            return new ArDecoSofa();
        }

        public IModernProduct CreateModernProduct()
        {
            return new ModernSofa();
        }

        public IVictorianProduct CreateVictorianProduct()
        {
            return new VictorianSofa();
        }
    }
}
