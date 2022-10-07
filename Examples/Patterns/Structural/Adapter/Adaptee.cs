namespace Patterns.Structural.Adapter
{
    public class Adaptee
    {
        private string _immutable = "I am immutable object";
        public string SpecificMethod()
        {
            return $"I Process {_immutable}";
        }
    }
}
