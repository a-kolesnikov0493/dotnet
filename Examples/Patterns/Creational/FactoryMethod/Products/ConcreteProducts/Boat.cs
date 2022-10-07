namespace Patterns.Creational.FactoryMethod.Products.ConcreteProducts
{
    public class Boat : Product, IProduct
    {
        private readonly string _name = "Default Boat";
        private readonly ProductTypeEnum _type = ProductTypeEnum.Boat;
        private readonly decimal _price = 100.00m;

        public Boat()
        {
            Name = _name;
            Type = _type;
            Price = _price;
        }

        public IProduct Initialize()
        {
            return new Boat();
        }
    }
}
