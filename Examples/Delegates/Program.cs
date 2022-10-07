using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var condition = Condition.Condition1;
            var rule = FuncResult(condition)("Vendor 1");

            string message = "";

            var myrule = rule as FirstRule;
            {
                message = rule.ReturnRule(myrule.VendorId);
            }

            Console.WriteLine(message);
        }

        public static Func<string, IRule> FuncResult(Condition condition)
        {
            var resolver = new RuleResolver();

            switch (condition)
            {
                case Condition.Condition1:
                    return resolver.ReturnFirstRule;
                case Condition.Condition2:
                    return resolver.ReturnSecondRule;
            }

            return null;
        }
    }

    public class RuleResolver : IRuleProvider
    {
        public IRule ReturnFirstRule(string vendor)
        {
            switch (vendor)
            {
                case "Vendor 1": return new FirstRule(int.Parse(vendor.Split(" ")[1]), "My message for Vendor1");
                case "Vendor 2": return new FirstRule(int.Parse(vendor.Split(" ")[1]), "My message for Vendor2");
                default: return new FirstRule(0, "defaultFirstRule");
            }
        }

        public IRule ReturnSecondRule(string vendor)
        {
            switch (vendor)
            {
                case "Vendor 1": return new SecondeRule(int.Parse(vendor.Split(" ")[1]), "My message for Vendor1");
                case "Vendor 2": return new SecondeRule(int.Parse(vendor.Split(" ")[1]), "My message for Vendor2");
                default: return new FirstRule(0, "defaultSecondRule");
            }
        }
    }
    public class SecondeRule : IRule
    {
        public int VendorId { get; set; }
        public string Message { get; set; }

        public SecondeRule(int id, string message)
        {
            VendorId = id + 1000;
            Message = message;
        }
        public string ReturnRule(int vendorId)
        {
            switch (vendorId)
            {
                case 1:
                    return "SecondRule - vendor id = 1" + Message + "new vendorId -" + VendorId;
                case 2:
                    return "SecondRule - vendor id = 2" + Message + "new vendorId -" + VendorId;
                default:
                    return "SecondRule - vendor id unknown";
            }
        }
    }
    public class FirstRule : IRule
    {
        public int VendorId { get; set; }
        public string Message { get; set; }

        public FirstRule(int id, string message)
        {
            VendorId = id + 2000;
            Message = message;
        }
        public string ReturnRule(int vendorId)
        {
            switch (vendorId)
            {
                case 1:
                    return "FirstRule - vendor id = 1" + "new vendorId -" + VendorId;
                case 2:
                    return "FirstRule - vendor id = 2" + "new vendorId -" + VendorId;
                default:
                    return "FirstRule - vendor id unknown";
            }
        }
    }

    public interface IRule
    {
        string ReturnRule(int vendorId);
    }

    public interface IRuleProvider
    {
        IRule ReturnFirstRule(string vendor);
        IRule ReturnSecondRule(string vendor);
    }

    public enum Condition
    {
        Condition1,
        Condition2
    }
}
