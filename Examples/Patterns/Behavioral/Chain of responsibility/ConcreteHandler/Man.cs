namespace Patterns.Behavioral.Chain_of_responsibility.ConcreteHandler
{
    public class Man : AbstractHandler
    {
        public override string Name => "Man";

        public override Response Handle(Request request)
        {
            if (request.Food.Equals("Coffee"))
                return new Response() { IsEatable = true, Handler = Name };

            return base.Handle(request);
        }
    }
}
