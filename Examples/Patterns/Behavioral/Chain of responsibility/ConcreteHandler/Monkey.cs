namespace Patterns.Behavioral.Chain_of_responsibility.ConcreteHandler
{
    public class Monkey : AbstractHandler
    {
        public override string Name => "Monkey";

        public override Response Handle(Request request)
        {
            if (request.Food.Equals("Banana"))
            {
                return new Response { IsEatable = true , Handler = Name};
            }

            return base.Handle(request);
        }
    }
}
