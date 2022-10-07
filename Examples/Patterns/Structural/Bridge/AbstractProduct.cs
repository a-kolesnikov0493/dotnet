using Patterns.Structural.Bridge.Implementations.Enums;
using Patterns.Structural.Bridge.Implementations.Interfaces;

namespace Patterns.Structural.Bridge
{
    public class AbstractProduct : Product
    {
        protected IStyle _style;
        protected IType _type;

        public AbstractProduct(IStyle style, IType type)
        {
            _style = style;
            _type = type;
        }

        public virtual ProductStyle Style => _style.Style;
        public virtual ProductType Type => _type.Type;
    }
}
