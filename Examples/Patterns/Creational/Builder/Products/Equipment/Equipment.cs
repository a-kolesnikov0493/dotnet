using Patterns.Creational.Builder.Products.Interfaces;

namespace Patterns.Creational.Builder.Products.Equipment

{
    public abstract class Equipment : IBuiltElement
    {
        public abstract EquipmentType Type { get; }
    }
}
