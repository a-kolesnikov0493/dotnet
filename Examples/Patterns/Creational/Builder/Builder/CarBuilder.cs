using Patterns.Creational.Builder.Products;
using Patterns.Creational.Builder.Products.Equipment;
using Patterns.Creational.Builder.Products.Interfaces;

namespace Patterns.Creational.Builder.Builder
{
    public class CarBuilder : IBuilder<IBuiltElement>
    {
        private Car _sportCar;
        public void Reset()
        {
            _sportCar = new SportCar();
        }

        public void SetEngine(IBuiltElement engine)
        {
            _sportCar.Engine = (Engine)engine;
        }

        public void SetGps(IBuiltElement gps)
        {
            _sportCar.Gps = (Gps)gps;
        }

        public void SetSeats(IBuiltElement seats)
        {
            _sportCar.Seat = (Seat)seats;
        }

        public void SetTripComputer(IBuiltElement tripComputer)
        {
            _sportCar.TripComputer = (TripComputer)tripComputer;
        }

        public Car Get()
        {
            return _sportCar;
        }
    }
}
