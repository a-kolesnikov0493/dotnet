using System.Collections.Generic;

namespace Patterns.Structural.Composite
{
    public class Package : Component
    {
        protected List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override decimal ShowPrice()
        {
            decimal fullPrice = 0m;

            foreach(var child in _children)
            {
                fullPrice += child.ShowPrice();
            }

            return fullPrice;
        }
    }
}
