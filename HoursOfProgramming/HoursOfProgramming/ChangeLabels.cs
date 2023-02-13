using System;

namespace HoursOfProgramming
{
    public class ChangeLabels
    {
        Adjusting adjusting = new Adjusting();

        public void UpdatingLabel(ref int valuesTimeOne, ref int valuesTimeTwo, Label labelOne, Label labelTwo)
        {
            if (valuesTimeTwo < 9)
            {
                adjusting.AdjustingIndicators(ref valuesTimeOne, ref valuesTimeTwo, labelOne);
                UpTen(labelTwo, valuesTimeTwo);
            }
            else
            {
                adjusting.AdjustingIndicators(ref valuesTimeOne, ref valuesTimeTwo, labelOne);
                AfterTen(labelTwo, valuesTimeTwo);
            }
        }

        public void UpdatingLabel(ref int valuesTime, Label label)
        {
            if (valuesTime < 9)
            {
                valuesTime++;
                UpTen(label, valuesTime);
            }
            else
            {
                valuesTime++;
                AfterTen(label, valuesTime);
            }
        }

        private void UpTen(Label label, int valuesTime)
        {
            label.Text = $"0{valuesTime.ToString()}";
        }

        private void AfterTen(Label label, int valuesTime)
        {
            label.Text = $"{valuesTime.ToString()}";
        }   
    }
}
