using System;

namespace Patterns.Creational.Prototype
{
    public class Person : ICloneable
    {
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public IdInfo IdInfo { get; set; }


        public object Clone()
        {
            Person clone = (Person)MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            return clone;
        }
    }
}
