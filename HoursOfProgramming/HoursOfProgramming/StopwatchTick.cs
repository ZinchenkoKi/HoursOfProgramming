using System;

namespace HoursOfProgramming
{
    public class StopwatchTick
    {
        UpdateLable updateLable = new UpdateLable();
        UpdatingIndicators updatingIndicators = new UpdatingIndicators();

        public TimeInApp Tick(TimeInApp timeInApp,Label labelOne, Label labelTwo, Label labelThree)
        {
            updatingIndicators.Update(timeInApp);
            updateLable.Update(timeInApp, labelOne, labelTwo, labelThree);
            return timeInApp;
        }
    }
}
