using Patterns.Structural.Bridge.Implementations.Enums;
using Patterns.Structural.Bridge.Implementations.Interfaces;

namespace Patterns.Structural.Bridge.Implementations.Styles
{
    public class ArDecoStyle : IStyle
    {
        public ProductStyle Style => ProductStyle.ArDeco;
    }
}
