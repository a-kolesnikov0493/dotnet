using Patterns.Creational.AbstractFactory.Products.ConcreteProduct.Interfaces.Styles;
using Patterns.Creational.AbstractFactory.Products.ConcreteProduct.Interfaces.Types;

namespace Patterns.Creational.AbstractFactory.Products.ConcreteProduct.Victorian
{
    public class VictorianChair : Chair, IVictorianProduct
    {
        public override ProductStyleType Style => ProductStyleType.Victorian;
    }
}
