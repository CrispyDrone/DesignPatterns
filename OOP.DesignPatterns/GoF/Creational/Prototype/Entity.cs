using OOP.DesignPatterns.GoF.Creational.Prototype.Interfaces;

namespace OOP.DesignPatterns.GoF.Creational.Prototype
{
    public abstract class Entity : IPrototype
    {
        private static int _maxId = 0;

        // basic properties
        public int Id;
        public Vector2D Position;
        public Vector2D Speed;
        public Vector2D Acceleration;

        // Clone
        public abstract Entity Clone();
        public int GetNextId()
        {
            return ++_maxId;
        }
    }

    public struct Vector2D
    {
        public int x;
        public int y;
    }
}
