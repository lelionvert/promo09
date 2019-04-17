namespace SocratesFrance
{
    public class Pricing
    {
        Priceable meal;

        public Pricing(Priceable meal)
        {
            this.meal = meal;
        }

        public int ComputeTotalPrice(Participant participant)
        {
            
            return participant.GetAccomodationPrice() + participant.ComputeMealCount() * meal.Price;
        }
    }
}
