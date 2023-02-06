using System;
using System.Drawing;

namespace HoursOfProgramming
{
    internal class StopwatchOperation
    {
        ChangeLabels changeLabels = new ChangeLabels();

        internal void StopwatchProcess(TimeInApp timeInApp, Label labelOne, Label labelTwo, Label labelThree)
        {
            StopwatchTick(timeInApp, labelOne, labelTwo, labelThree);
        }

        private void StopwatchTick(TimeInApp timeInApp, Label labelOne, Label labelTwo, Label labelThree)
        {
            if (CheckingNumber(timeInApp.minutesInApp))
            {
                UpdatingLabelValue(ref timeInApp.minutesInApp, ref timeInApp.hoursInApp, labelTwo, labelThree);
            }
            else if (CheckingNumber(timeInApp.secondsInApp))
            {
                UpdatingLabelValue(ref timeInApp.secondsInApp, ref timeInApp.minutesInApp, labelOne, labelTwo);
            }
            else
            {
                UpdatingLabelValue(ref timeInApp.secondsInApp, labelOne);
            }
        }

        private bool CheckingNumber(int values)
        {
            return values > 59 ? true : false;
        }

        private void UpdatingLabelValue(ref int valuesTimeOne, ref int valuesTimeTwo, Label labelOne, Label labelTwo)
        {
            if (valuesTimeTwo < 9)
            {
                AdjustingIndicators(ref valuesTimeOne, ref valuesTimeTwo, labelOne);
                changeLabels.UpTen(labelTwo, valuesTimeTwo);
            }
            else
            {
                AdjustingIndicators(ref valuesTimeOne, ref valuesTimeTwo, labelOne);
                changeLabels.AfterTen(labelTwo, valuesTimeTwo);
            }
        }

        private void AdjustingIndicators(ref int valuesTimeOne, ref int valuesTimeTwo, Label labelOne)
        {
            valuesTimeOne = 0;
            valuesTimeTwo++;
            changeLabels.ResetMeaning(labelOne);
        }

        private void UpdatingLabelValue(ref int valuesTime, Label label)
        {
            if (valuesTime < 9)
            {
                valuesTime++;
                changeLabels.UpTen(label, valuesTime);
            }
            else
            {
                valuesTime++;
                changeLabels.AfterTen(label, valuesTime);
            }
        }
    }
}
