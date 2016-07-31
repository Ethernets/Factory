namespace MyFactory
{
    using System;
    using Factory;
    using Product;
    using Product.Reebok;

    public class Program
    {
        static void Main(string[] args)
        {
            DressFactoryBase nike = new NikeCollection();

            Client client1 = new Client(nike);

            client1.Material();

            DressFactoryBase reebok = new ReebokCollection();

            Client client2 = new Client(reebok);

            client2.Material();

            Console.Read();
        }
    }
}
