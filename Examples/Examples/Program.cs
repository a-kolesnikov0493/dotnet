using DataStructure.BinaryTree;
using Patterns.Behavioral.Chain_of_responsibility;
using Patterns.Behavioral.Chain_of_responsibility.ConcreteHandler;
using Patterns.Behavioral.Command;
using Patterns.Behavioral.Iterator;
using Patterns.Structural.Decorator.Notifiers;
using Patterns.Structural.Proxy;
using System;
using System.Collections.Generic;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            #region FactoryMethod
            //var factoryMethodManager = new FactoryMethodManager();
            //var product = factoryMethodManager.WorkWithTrucks();
            //Console.WriteLine(product);
            #endregion

            #region AbstractFactory Method
            //var factory = new ChairFactory();
            //var guid = Guid.NewGuid();
            //var ardecoChair = factory.CreateArDecoProduct(guid, "My ArDeco Chair", 187.0m);


            //var factory2 = new GenericFactory<ArDecoSofa>();
            //var guid2 = Guid.NewGuid();
            //var ardecosofa = factory2.CreateProduct(guid2, "Sofa", 200.0m);

            //var type = ardecosofa.Type;
            //var style = ardecosofa.Style;


            //Console.WriteLine(ardecosofa);
            #endregion

            #region Builder
            //var director = new Director();
            //var carBuilder = new CarBuilder();
            //director.BuildSportCar(carBuilder);

            //var car = carBuilder.Get();
            #endregion

            #region Prototype
            //var person = new Person()
            //{
            //    Age = 11,
            //    BirthDate = DateTime.Now,
            //    Name = "Tolik",
            //    IdInfo = new IdInfo(1)
            //};


            //var tolik = person.Clone();


            //person.Age = 44;

            #endregion

            #region Adapter
            //var obj = new Adaptee();
            //var specific = obj.SpecificMethod();

            //var adapter = new Adapter(obj);
            //var adapted = adapter.Run();

            //Console.WriteLine(specific);
            //Console.WriteLine(adapted);
            #endregion

            #region Bridge

            //var modern = new ModernStyle();
            //var chair = new Chair();
            //var arDeco = new ArDecoStyle();
            //var table = new Table();
            //var victorian = new VictorianStyle();

            //var modernChair = new AbstractProduct(modern, chair);
            //var ardecoChair2 = new AbstractProduct(arDeco, chair);
            //var modernTable = new AbstractProduct(modern, table);
            //var ardecoTable = new AbstractProduct(arDeco, table);


            //var victorianChair = new AbstractProduct(victorian, chair);

            #endregion

            #region Composite
            //var phone1 = new Phone() { Price = 100m };
            //var phone2 = new Phone() { Price = 130m };
            //var phone3 = new Phone() { Price = 105m };

            //var box = new Package();
            //box.Add(phone1);
            //box.Add(phone2);

            //var box2 = new Package();
            //box2.Add(phone3);

            //var mainBox = new Package();
            //mainBox.Add(box);
            //mainBox.Add(box2);

            //var price = mainBox.ShowPrice();
            #endregion

            #region Decorator
            //var slack = new SlackProgram(new SlackNotifier());
            //var sms = new SmsProgram(new SmsNotifier());

            //client.UseDecorator(slack, "Hello");
            //client.UseDecorator(sms, "Hello");

            //client.UseDecorator(new SlackNotifier(), "Hello");
            //client.UseDecorator(new SmsNotifier(), "Hello");
            #endregion

            #region Proxy
            //var proxy = new CachedYouTube(new ThirdPartyYouTube());

            //Console.WriteLine(client.UseProxy(proxy, Reference.CatVideo));
            //Console.WriteLine(client.UseProxy(proxy, Reference.CatVideo));
            //Console.WriteLine(client.UseProxy(proxy, Reference.OmgVideo));
            #endregion

            #region Chain of Responsibility

            //var requestChain = new List<Request>()
            //{
            //    new Request() { Food = "Banana" },
            //    new Request() { Food = "Coffee" },
            //    new Request() { Food = "Meat" },
            //};

            //var monkey = new Monkey();
            //var dog = new Dog();
            //var man = new Man();

            //// chain sequence
            //monkey.SetNext(dog).SetNext(man);

            //client.UseChain(monkey, requestChain);
            //Console.WriteLine();

            //client.UseChain(dog, requestChain);
            #endregion

            #region Command
            //var receiver = new Receiver();
            //var invoker = new Invoker(new SimpleCommand("Say Hi"), new ComplexCommand("Send email", "Save report", receiver));

            //invoker.DoSomethingImportant();
            #endregion

            #region Iterator

            #endregion
        }
    }


    public class Client
    {
        public void UseDecorator(INotifier notifier, string message)
        {
            Console.WriteLine(notifier.Notify(message));
        }

        public string UseProxy(IThirdPartyYouTube thirdPartyYouTube, Reference reference)
        {
            return thirdPartyYouTube.DownloadVideo(reference);
        }

        public void UseChain(AbstractHandler abstractHandler, List<Request> requestChain)
        {
            foreach (var link in requestChain)
            {
                Console.WriteLine($"Who wants a {link.Food}?");

                var result = abstractHandler.Handle(link);

                if (result.IsEatable)
                {
                    Console.WriteLine($"{result.Handler} eats {link.Food}");
                }
                else
                {
                    Console.WriteLine($"{link.Food} was left untouched");
                }
            }
        }


    }
}
