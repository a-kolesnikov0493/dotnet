using Patterns.Creational.AbstractFactory.Factories.Interfaces;
using Patterns.Creational.AbstractFactory.Products;
using System;

namespace Patterns.Creational.AbstractFactory.Factories
{
    public class GenericFactory<T> : IGenericAbstractFactory<T> where T : Product, new()
    {
        public T CreateProduct(Guid id, string name, decimal price)
        {
            return new T() { Id = id, Name = name, Price = price };
        }
    }
}
