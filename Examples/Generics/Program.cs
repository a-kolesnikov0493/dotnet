using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order { OrderNumber = "123456", WhatActionDo = ConditionsEnum.Condition1 };

            var result = Resolver.Resolve<SuperAction>(order);

            var orderNumber = result.Name;
            var orderAction = result.Action.Action.ToString();

            Console.WriteLine(orderNumber);
            Console.WriteLine(orderAction);
        }
    }


    public class Result<TAction>
    {
        public Result(string name, TAction action)
        {
            Name = name;
            Action = action;
        }
        public string Name { get; }
        public TAction Action { get; }
    }

    public class Order
    {
        public string OrderNumber { get; set; }

        // здесь может быть переменная, которая отвечает за параметр, который будет передаваться в ActionResolver
        // таких переменных может быть много (в данном классе всего одна)
        // из комбинаций этих условий в конечном итоге передаётся в ActionResolver
        public ConditionsEnum WhatActionDo { get; set; }
    }

    public static class Resolver
    {
        public static Result<TAction> Resolve<TAction>(Order order) where TAction : SuperAction
        {
            var action = ActionResolver.Result<TAction>(order.WhatActionDo);
            return new Result<TAction>(order.OrderNumber, action);
        }
    }

    public static class ActionResolver
    {
        public static T Result<T>(ConditionsEnum whatActionDo) where T : SuperAction
        {
            switch (whatActionDo)
            {
                case ConditionsEnum.Condition1:
                    return (T)new SuperAction { Action = ActionsEnum.Do1 };
                case ConditionsEnum.Condition2:
                    return (T)new SuperAction { Action = ActionsEnum.Do2 };
                case ConditionsEnum.Condition3:
                    return (T)new SuperAction { Action = ActionsEnum.Do3 };
                default:
                    return (T)new SuperAction { Action = ActionsEnum.DefaultAction };

            }
        }
    }

    public class MyAction1 : IAction
    {
        public void Do()
        {
            Console.WriteLine("MyAction Do();");
        }
    }
    public class MyAction2 : IAction
    {
        public void Do()
        {
            Console.WriteLine("MyAction2 Do();");
        }
    }
    public class MyAction3 : IAction
    {
        public void Do()
        {
            Console.WriteLine("MyAction3 Do();");
        }
    }

    public interface IAction
    {
        void Do();
    }

    public enum ConditionsEnum
    {
        Condition1 = 1,
        Condition2 = 2,
        Condition3 = 3
    }

    public enum ActionsEnum
    {
        DefaultAction = 0,
        Do1 = 1,
        Do2 = 2,
        Do3 = 3
    }

    public class SuperAction
    {
        public ActionsEnum Action { get; set; }
    }
}
