using System;

namespace OOP.DesignPatterns.GoF.Creational.Prototype.Interfaces
{
    public interface IEntityPrototypeFactory
    {
        void Register(Entity entity);
        void UnRegister(Type entityType);
        Entity Create(Type type);
    }
}
