using Patterns.Structural.Bridge.Implementations.Enums;
using Patterns.Structural.Bridge.Implementations.Interfaces;

namespace Patterns.Structural.Bridge.Implementations.Types
{
    public class NoType : IType
    {
        public ProductType Type => ProductType.None;
    }
}
