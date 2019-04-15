
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
            if (checkIn != null)
                return true;
            return false;
        }
    }
}