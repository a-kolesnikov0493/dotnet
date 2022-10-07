using Patterns.Creational.AbstractFactory.Products.ConcreteProduct.Interfaces.Styles;
using Patterns.Creational.AbstractFactory.Products.ConcreteProduct.Interfaces.Types;

namespace Patterns.Creational.AbstractFactory.Products.ConcreteProduct.ArDeco
{
    public class ArDecoSofa: Sofa, IArDecoProduct
    {
        public override ProductStyleType Style => ProductStyleType.ArDeco;
    }
}
