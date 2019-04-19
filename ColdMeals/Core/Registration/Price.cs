namespace Socrates
{
    public struct Price
    {
        private int _value;
        public static Price Of(int value)
        {
            return new Price(value);
        }

        private Price(int value)
        {
            _value = value;
        }

        internal Price Add(Price price)
        {
            return Price.Of(_value + price._value);
        }

        internal Price Times(int number)
        {
            return Price.Of(_value * number);
        }
    }
}