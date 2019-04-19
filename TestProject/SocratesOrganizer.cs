using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocratesFrance
{
    public class SocratesOrganizer
    {
        private readonly DateTime sessionStart;
        private readonly DateTime sessionEnd;

        public SocratesOrganizer(DateTime sessionStart, DateTime sessionEnd)
        {
            this.sessionStart = sessionStart;
            this.sessionEnd = sessionEnd;
        }

        public int ComputeMealCount(Registration registration)
        {
            int mealCount = 6;

            if (registration.CheckOut.IsSooner(this.sessionEnd))
            {
                mealCount--;
            }
            if (registration.CheckIn.IsLater(this.sessionStart))
            {
                mealCount--;
            }
            return mealCount;
        }
    }
}
