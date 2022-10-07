namespace Patterns.Behavioral.Chain_of_responsibility
{
    public interface IHandler<TResponse, TRequest>
        where TResponse : Response
        where TRequest : Request
    {
        IHandler<TResponse, TRequest> SetNext(IHandler<TResponse, TRequest> handler);
        TResponse Handle(TRequest request);
    }
}
