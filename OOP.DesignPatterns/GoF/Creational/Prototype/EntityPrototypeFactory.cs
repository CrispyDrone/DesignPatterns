using OOP.DesignPatterns.GoF.Creational.Prototype.Interfaces;
using System.Collections.Generic;
using System;

namespace OOP.DesignPatterns.GoF.Creational.Prototype
{
    public class EntityPrototypeFactory : IEntityPrototypeFactory
    {
        private Dictionary<Type, Entity> _typesToEntities = new Dictionary<Type, Entity>();

        public Entity Create(Type type)
        {
            if (!_typesToEntities.ContainsKey(type)) throw new Exception("Can't create type as it has not been registered!");

            return _typesToEntities[type].Clone();
        }

        public void Register(Entity entity)
        {
            _typesToEntities[entity.GetType()] = entity;
        }

        public void UnRegister(Type entityType)
        {
            if (!_typesToEntities.ContainsKey(entityType)) return;

            _typesToEntities.Remove(entityType);
        }
    }
}
