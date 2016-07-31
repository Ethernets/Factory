namespace MyFactory.Factory
{
   public abstract class DressFactoryBase
    {
        public abstract AbstractSportSuit CreateSuit();

        public abstract AbstractMaterial CreateMaterial();
    }
}
