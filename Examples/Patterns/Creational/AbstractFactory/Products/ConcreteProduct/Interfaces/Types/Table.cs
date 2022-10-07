namespace Patterns.Creational.AbstractFactory.Products.ConcreteProduct.Interfaces.Types
{
    public abstract class Table : Product
    {
        public override ProductType Type => ProductType.Table;
    }
}
