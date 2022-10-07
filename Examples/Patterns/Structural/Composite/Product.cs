namespace Patterns.Structural.Composite
{
    public abstract class Product : Component
    {
        public decimal Price { get; set; }
        public override decimal ShowPrice() => Price;

        public override bool IsComposite => false;
    }
}
