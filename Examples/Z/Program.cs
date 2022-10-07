using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            var option1List = new List<Radio<Option1>>();

            option1List.Add();
        }
    }

    public class Radio<TOption>
    {
        public TOption Options { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }
        public bool Disabled { get; set; }
    }

    public enum Option1
    {
        Field1 = 1,
        Field2 = 2,
    }

    public enum Option2
    {
        Field1 = 1,
        Field2 = 2,
    }

    public class HousingProgram
    {
        public int ProgramCode { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }
    }
}
