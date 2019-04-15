
namespace SocratesFrance
{
    public class Participant
    {
        private CheckIn checkIn;
        
        public Participant(CheckIn checkIn = null)
        {
            this.checkIn = checkIn;
        }

        public bool HasCheckin()
        {
            return checkIn != null;
        }
    }
}