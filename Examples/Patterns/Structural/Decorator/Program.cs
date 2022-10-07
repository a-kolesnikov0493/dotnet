using Patterns.Structural.Decorator.Notifiers;

namespace Patterns.Structural.Decorator
{
    public abstract class Program : INotifier
    {
        protected INotifier Notifier;
        public Program(INotifier notifier)
        {
            Notifier = notifier;
        }
        public virtual string Notify(string message)
        {
            return Notifier.Notify(message);
        }
    }
}
