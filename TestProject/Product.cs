namespace SocratesFrance
{
    public abstract class Product
    {
        protected string name;

        protected Product(string productName)
        {
            name = productName;
        }
    }

    public class ConsumableProduct : Product
    {
        public static readonly ConsumableProduct MEAL = new ConsumableProduct("Meal");

        private ConsumableProduct(string productName) : base(productName)
        {}
    }

    public class Room : Product
    {
        public static readonly Room SINGLE_ACCOMMODATION = new Room("Single Room");
        public static readonly Room DOUBLE_ACCOMMODATION = new Room("Double Room");
        public static readonly Room TRIPLE_ACCOMMODATION = new Room("Triple Room");
        public static readonly Room NO_ACCOMMODATION = new Room("No Accommodation");

        private Room(string roomType) : base(roomType)
        {}
    }
}