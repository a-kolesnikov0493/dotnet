using CommandPattern.Commands;
using CommandPattern.Factory;
using CommandPattern.Service;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4) using FactroyManager with flag

            var smscResponseModel = new SmscResponseModel() { Command = 2 };
            var manager = new FactoryManager();
            manager.ExtractCommand(smscResponseModel);

            //// 3) using FactoryManager

            //var smscResponseModel3 = new SmscResponseModel() { Command = 2 };
            //var manager2 = new FactoryManager();
            //var command = manager2.RunCommand(smscResponseModel3);
            //var service = new CommandService<ICommand>();

            //var result = service.Execute(command);
            //result.Execute();

            //// 2) using Command and Factory patterns

            //var creator = new CheckInCommandCreator();
            //creator.Execute();

            //var creator2 = new SosCommandCreator();
            //creator2.Execute();


            //// 1) using only Command Pattern
            //var service2 = new CommandService<ICommand>();

            //var sosCommand = new SosCommand();
            //var checkInCommand = new CheckInCommand();

            //var sos = service2.Execute(sosCommand);
            //var checkIn = service2.Execute(checkInCommand);

            //sos.Execute();
            //checkIn.Execute();
        }
    }
}
