using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursOfProgramming
{
    public class RecalculationTime
    {
        internal void Recalculation(TimeInFile timeInFile, TimeInApp timeInApp)
        {
            timeInFile.secondsInFile += timeInApp.secondsInApp;
            timeInFile.minutesInFile += timeInApp.minutesInApp;
            timeInFile.hoursInFile += timeInApp.hoursInApp;
        }
    }
}
