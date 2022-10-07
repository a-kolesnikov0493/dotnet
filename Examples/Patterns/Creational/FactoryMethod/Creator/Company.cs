using Patterns.Creational.FactoryMethod.Products;

namespace Patterns.Creational.FactoryMethod.Creator
{
    /// <summary>
    /// Creator
    /// </summary>
    public abstract class Company
    {
        public abstract IProduct CreateProduct();
        public IProduct SomeOperation()
        {
            var product = CreateProduct();
            var result = product.Initialize();

            return result;
        }
    }
}
