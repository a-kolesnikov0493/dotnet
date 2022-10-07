namespace Patterns.Structural.Adapter
{
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string Run()
        {
            var specific = _adaptee.SpecificMethod();
            return specific.Replace("I am immutable object", "the object, but it was changed.");
        }
    }
}
