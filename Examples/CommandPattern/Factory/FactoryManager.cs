using CommandPattern.Commands;
using System;

namespace CommandPattern.Factory
{
    public class FactoryManager
    {
        private AbstractCreator _creator;

        // 3 option
        //public ICommand RunCommand(SmscResponseModel smscResponseModel)
        //{
        //    switch (smscResponseModel.Command)
        //    {
        //        case 2:
        //            _creator = new SosCommandCreator();
        //            return _creator.FactoryMethod();
        //        case 1:
        //            _creator = new CheckInCommandCreator();
        //            return _creator.FactoryMethod();
        //        default:
        //            throw new Exception("No command");
        //    }
        //}

        // 4 option
        public void ExtractCommand(SmscResponseModel smscResponseModel)
        {
            _creator = new CheckInCommandCreator();
            _creator.Execute(smscResponseModel.Command);
        }
    }
}
