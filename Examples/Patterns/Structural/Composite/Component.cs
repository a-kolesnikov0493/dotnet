namespace Patterns.Structural.Composite
{
    public abstract class Component
    {
        public abstract decimal ShowPrice();

        public virtual void Add(Component component) { }
        public virtual void Remove(Component component) { }

        public virtual bool IsComposite => true;
    }
}
