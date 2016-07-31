namespace MyFactory
{
    using Factory;

   public class Client
    {
        private AbstractMaterial abstractMaterial;

        private AbstractSportSuit abstractSportSuit;

        public Client(DressFactoryBase dress_factory)
        {
            abstractMaterial = dress_factory.CreateMaterial();

            abstractSportSuit = dress_factory.CreateSuit();
        }

        public void Material()
        {
            abstractSportSuit.MaxCotton(abstractMaterial);
        }
    }
}
