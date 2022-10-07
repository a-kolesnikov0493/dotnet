using Patterns.Creational.AbstractFactory.Products;
using System;

namespace Patterns.Creational.AbstractFactory.Factories.Interfaces
{
    public interface IGenericAbstractFactory<T> where T : Product
    {
        T CreateProduct(Guid id, string name, decimal price);
    }
}
