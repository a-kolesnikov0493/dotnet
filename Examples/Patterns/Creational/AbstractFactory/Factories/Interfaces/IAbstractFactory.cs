using Patterns.Creational.AbstractFactory.Products.ConcreteProduct.Interfaces.Styles;
using System;

namespace Patterns.Creational.AbstractFactory.Factories
{
    public interface IAbstractFactory
    {
        IArDecoProduct CreateArDecoProduct(Guid id, string name, decimal price);
        IVictorianProduct CreateVictorianProduct();
        IModernProduct CreateModernProduct();
    }
}
