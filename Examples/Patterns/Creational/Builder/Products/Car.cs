using Patterns.Creational.Builder.Products.Equipment;

namespace Patterns.Creational.Builder.Products
{
    public abstract class Car
    {
        public Seat Seat { get; set; }
        public Engine Engine { get; set; }
        public TripComputer TripComputer { get; set; }
        public Gps Gps { get; set; }
    }
}
