using Patterns.Creational.FactoryMethod.Creator;
using Patterns.Creational.FactoryMethod.Products;
using Patterns.Creational.FactoryMethod.Products.ConcreteProducts;

namespace Patterns.Creational.FactoryMethod.ConcreteCreators
{
    public class BoatCreator : Company
    {
        public override IProduct CreateProduct()
        {
            return new Boat();
        }
    }
}
