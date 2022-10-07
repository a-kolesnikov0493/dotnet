using CommandPattern.Commands;
using CommandPattern.Service;

namespace CommandPattern.Factory
{
    public class CheckInCommandCreator : AbstractCreator
    {
        public override ICommand FactoryMethod(int command)
        {
            return new CheckInCommand();
        }
    }
}
