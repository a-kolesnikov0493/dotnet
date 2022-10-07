using Patterns.Creational.Builder.Products.Interfaces;

namespace Patterns.Creational.Builder.Products.Info
{
    public abstract class Info : IBuiltElement
    {
        public virtual string Information { get; set; }
    }
}
