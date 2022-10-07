using Patterns.Creational.FactoryMethod.ConcreteCreators;
using Patterns.Creational.FactoryMethod.Creator;
using Patterns.Creational.FactoryMethod.Products;

namespace Examples
{
    public class FactoryMethodManager
    {
        public IProduct WorkWithBoats()
        {
            return Manage(new BoatCreator());
        }

        public IProduct WorkWithTrucks()
        {
            return Manage(new TruckCreator());
        }

        private IProduct Manage(Company company)
        {
            return company.CreateProduct();
        }
    }
}
