namespace Patterns.Behavioral.Chain_of_responsibility
{
    public abstract class AbstractHandler : IHandler<Response, Request>
    {
        private IHandler<Response, Request> _next;
        public abstract string Name { get; }

        public virtual Response Handle(Request request)
        {
            if (_next is not null)
                return _next.Handle(request);

            return new Response() { IsEatable = false };
        }

        public IHandler<Response, Request> SetNext(IHandler<Response, Request> handler)
        {
            _next = handler;
            return handler;
        }
    }
}
