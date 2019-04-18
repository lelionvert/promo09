namespace SocratesFrance
{
    public class Priceable
    {
        public Priceable(int price)
        {
            Price = price;
        }

        public int Price { get; private set; }
    }
}
