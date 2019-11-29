namespace OOP.DesignPatterns.GoF.Creational.Prototype
{
    public class GorillaMonster : Entity
    {
        public bool CanClimb;

        public override Entity Clone()
        {
            return new GorillaMonster
            {
                Id = GetNextId(),
                CanClimb = CanClimb,
                Acceleration = Acceleration,
                Position = Position,
                Speed = Speed
            };
        }
    }
}
