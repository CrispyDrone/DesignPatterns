namespace OOP.DesignPatterns.GoF.Creational.Prototype
{
    public class LizardMonster : Entity
    {
        public bool IsCamouflaged;
        public bool CanJump;

        public override Entity Clone()
        {
            return new LizardMonster
            {
                Id = GetNextId(),
                IsCamouflaged = IsCamouflaged,
                CanJump = CanJump,
                Acceleration = Acceleration,
                Position = Position,
                Speed = Speed
            };
        }
    }
}
