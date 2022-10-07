using CommandPattern.Commands;

namespace CommandPattern.Factory
{
    public class SosCommandCreator : AbstractCreator
    {
        public override ICommand FactoryMethod(int command)
        {
            return new SosCommand();
        }
    }
}
