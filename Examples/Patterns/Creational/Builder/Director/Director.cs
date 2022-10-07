using Patterns.Creational.Builder.Builder;
using Patterns.Creational.Builder.Products.Equipment;
using Patterns.Creational.Builder.Products.Interfaces;

namespace Patterns.Creational.Builder.Director
{
    public class Director
    {
        private CarBuilder _builder;
        public CarBuilder BuildSportCar(IBuilder<IBuiltElement> builder)
        {
            _builder = (CarBuilder)builder;

            builder.Reset();
            builder.SetEngine(new Engine());
            builder.SetGps(new Gps());
            builder.SetSeats(new Seat());
            builder.SetTripComputer(new TripComputer());

            return _builder;
        }
    }
}
