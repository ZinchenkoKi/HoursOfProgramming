using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursOfProgramming
{
    public class UpdatingIndicators
    {
        public TimeInApp Update(TimeInApp timeInApp)
        {
            UpdatingCounter(timeInApp);
            return timeInApp;
        }

        private TimeInApp UpdatingCounter(TimeInApp timeInApp)
        {
            timeInApp.SecondsInApp++;
            if (CheckingDozens(timeInApp.SecondsInApp))
            {
                timeInApp.MinutesInApp++;
                timeInApp.SecondsInApp = 0;
            }
            if (CheckingDozens(timeInApp.MinutesInApp))
            {
                timeInApp.HoursInApp++;
                timeInApp.MinutesInApp = 0;
            }
            return timeInApp;
        }

        private bool CheckingDozens(int values)
        {
            return values > 59 ? true : false;
        }
    }
}
