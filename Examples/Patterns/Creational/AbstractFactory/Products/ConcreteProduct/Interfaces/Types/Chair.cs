namespace Patterns.Creational.AbstractFactory.Products.ConcreteProduct.Interfaces.Types
{
    public abstract class Chair : Product
    {
        public override ProductType Type => ProductType.Chair;
    }
}
