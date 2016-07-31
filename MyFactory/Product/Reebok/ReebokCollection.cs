namespace MyFactory.Product.Reebok
{
    using Reebok;
    using Factory;
    using System;

    public class ReebokCollection : DressFactoryBase
    {
        public override AbstractMaterial CreateMaterial()
        {
            return new CottonReebok();
        }

        public override AbstractSportSuit CreateSuit()
        {
            return new SportSuitReebok();
        }
    }
}
