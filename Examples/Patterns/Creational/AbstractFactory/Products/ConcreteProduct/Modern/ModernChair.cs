using Patterns.Creational.AbstractFactory.Products.ConcreteProduct.Interfaces.Styles;
using Patterns.Creational.AbstractFactory.Products.ConcreteProduct.Interfaces.Types;

namespace Patterns.Creational.AbstractFactory.Products.ConcreteProduct.Modern
{
    public class ModernChair : Chair, IModernProduct
    {
        public override ProductStyleType Style => ProductStyleType.Modern;
    }
}
