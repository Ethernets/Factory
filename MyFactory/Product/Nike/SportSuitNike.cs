namespace MyFactory.Product.Nike
{
    using System;
    using Factory;

    public class SportSuitNike : AbstractSportSuit
    {
        public override void MaxCotton(AbstractMaterial material)
        {
            Console.WriteLine("Содержание хлопка в спорт. костюме Nike:" +material.max_cotton.ToString()+"%");
        }
    }
}
