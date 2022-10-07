using Patterns.Creational.Builder.Products.Interfaces;

namespace Patterns.Creational.Builder.Builder
{
    public interface IBuilder<T> where T : IBuiltElement
    {
        void Reset();
        void SetSeats(T seats);
        void SetEngine(T engine);
        void SetTripComputer(T tripComputer);
        void SetGps(T gps);
    }
}
