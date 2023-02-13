using System;

namespace HoursOfProgramming
{
    public class StopwatchOperation
    {
        ChangeLabels changeLabels = new ChangeLabels();
        
        internal void Tick(TimeInApp timeInApp, Label labelOne, Label labelTwo, Label labelThree)
        {
            StopwatchTick(timeInApp, labelOne, labelTwo, labelThree);
        }

        private void StopwatchTick(TimeInApp timeInApp, Label labelOne, Label labelTwo, Label labelThree)
        {
            if (CheckingNumber(timeInApp.minutesInApp))
            {
                changeLabels.UpdatingLabel(ref timeInApp.minutesInApp, ref timeInApp.hoursInApp, labelTwo, labelThree);
            }
            else if (CheckingNumber(timeInApp.secondsInApp))
            {
                changeLabels.UpdatingLabel(ref timeInApp.secondsInApp, ref timeInApp.minutesInApp, labelOne, labelTwo);
            }
            else
            {
                changeLabels.UpdatingLabel(ref timeInApp.secondsInApp, labelOne);
            }
        }

        private bool CheckingNumber(int values)
        {
            return values > 59 ? true : false;
        }
    }
}
