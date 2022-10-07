using Patterns.Creational.Builder.Products;
using Patterns.Creational.Builder.Products.Info;
using Patterns.Creational.Builder.Products.Interfaces;

namespace Patterns.Creational.Builder.Builder
{
    public class ManualBuilder : IBuilder<IBuiltElement>
    {
        private CarManual _manual;
        public void Reset()
        {
            _manual = new SportCarManual();
        }

        public void SetEngine(IBuiltElement engine)
        {
            _manual.EngineInfo = (EngineInfo)engine;
        }

        public void SetGps(IBuiltElement gps)
        {
            _manual.GpsInfo = (GpsInfo)gps;
        }

        public void SetSeats(IBuiltElement seats)
        {
            _manual.SeatInfo = (SeatInfo)seats;
        }

        public void SetTripComputer(IBuiltElement tripComputer)
        {
            _manual.TripComputerInfo = (TripComputerInfo)tripComputer;
        }

        public CarManual Get()
        {
            return _manual;
        }
    }
}
