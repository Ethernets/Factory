namespace MyFactory.Product
{
    using System;
    using Factory;
    using Nike;

    public class NikeCollection : DressFactoryBase
    {
        public override AbstractMaterial CreateMaterial()
        {
            return new CottonNike();
        }

        public override AbstractSportSuit CreateSuit()
        {
            return new SportSuitNike();
        }
    }
}
