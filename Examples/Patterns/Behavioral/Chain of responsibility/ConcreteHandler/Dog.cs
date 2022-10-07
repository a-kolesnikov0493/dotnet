namespace Patterns.Behavioral.Chain_of_responsibility.ConcreteHandler
{
    public class Dog : AbstractHandler
    {
        public override string Name => "Dog";

        public override Response Handle(Request request)
        {
            if (request.Food.Equals("Meat"))
                return new Response() { IsEatable = true, Handler = Name };

            return base.Handle(request);
        }
    }
}
