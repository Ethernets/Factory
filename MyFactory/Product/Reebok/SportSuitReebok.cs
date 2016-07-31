namespace MyFactory.Product.Reebok
{
    using System;
    using Factory;
    using Reebok;

    public class SportSuitReebok : AbstractSportSuit
    {
        public override void MaxCotton(AbstractMaterial material)
        {
            Console.WriteLine("Содержание хлопка в спорт. костюме Reebok:" + material.max_cotton.ToString()+"%");
        }
    }
}
