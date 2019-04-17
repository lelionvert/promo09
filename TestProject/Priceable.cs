namespace SocratesFrance
{
    public class Priceable
    {
        int price;

        public Priceable(int price)
        {
            this.price = price;
        }

        public int Price { get => price; private set => price = value; }
    }
}
