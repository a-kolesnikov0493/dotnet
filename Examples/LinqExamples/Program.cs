using System;
using System.Linq;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find item by all conditions:
            var orderStatus = "Success";

            //var mainCondition = orderStatus == Statuses.Success || orderStatus == Statuses.Success2 || orderStatus == Statuses.Success3;
            //instead
            var mainCondition = new[]
            {
                Statuses.Success,
                Statuses.Success2,
                Statuses.Success3,
            }.Contains(orderStatus);
        }

        /// <summary>
        /// Checks whether the status matches all conditions
        /// </summary>
        /// <param name="currentStatus"></param>
        /// <returns>True if corresponds. False otherwise.</returns>
        private static bool IsStatusCorrespondAllConditions(string currentStatus)
        {
            //instead of
            //return currentStatus == Statuses.Success || currentStatus == Statuses.Success2 || currentStatus == Statuses.Success3;

            return new[]
            {
                Statuses.Success,
                Statuses.Success2,
                Statuses.Success3,
            }.Contains(currentStatus);
        }
    }

    

    public static class Statuses
    {
        public const string Success = "Success";
        public const string Success2 = "Success2";
        public const string Success3 = "Success3";
    }
}
