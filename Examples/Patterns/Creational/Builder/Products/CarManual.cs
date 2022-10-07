using Patterns.Creational.Builder.Products.Info;

namespace Patterns.Creational.Builder.Products
{
    public abstract class CarManual
    {
        public EngineInfo EngineInfo { get; set; }
        public GpsInfo GpsInfo { get; set; }
        public SeatInfo SeatInfo { get; set; }
        public TripComputerInfo TripComputerInfo { get; set; }
    }
}
