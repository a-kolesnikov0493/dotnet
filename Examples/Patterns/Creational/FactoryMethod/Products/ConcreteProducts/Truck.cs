namespace Patterns.Creational.FactoryMethod.Products.ConcreteProducts
{
    public class Truck : Product, IProduct
    {
        private readonly string _name = "Default Truck";
        private readonly ProductTypeEnum _type = ProductTypeEnum.Truck;
        private readonly decimal _price = 80.00m;

        public Truck()
{
            Name = _name;
            Type = _type;
            Price = _price;
        }

        public IProduct Initialize()
        {
            return new Truck();
        }
    }
}
