using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace HoursOfProgramming
{
    internal class StopwatchOperation
    {
        TimeInApp timeInApp = new TimeInApp();

        internal void StopwatchProcess(Label labelOne, Label labelTwo, Label labelThree)
        {
            if (CheckingNumber(timeInApp.minutes))
            {
                ConvertToNextLevel(ref timeInApp.minutes, ref timeInApp.hours, labelTwo, labelThree);
            }
            else if (CheckingNumber(timeInApp.seconds)) 
            {
                ConvertToNextLevel(ref timeInApp.seconds, ref timeInApp.minutes, labelOne,labelTwo);
            }
            else
            {
                CourseOfSeconds(ref timeInApp.seconds, labelOne);
            }
        }

        private bool CheckingNumber(int values)
        {
            return values > 59 ? true : false;
        }

        private void ConvertToNextLevel(ref int valuesTimeOne, ref int valuesTimeTwo, Label labelOne, Label labelTwo)
        {
            if (valuesTimeTwo < 9)
            {
                valuesTimeOne = 0;
                valuesTimeTwo++;
                labelTwo.Text = $"0{valuesTimeTwo.ToString()}";
            }
            else
            {
                valuesTimeOne = 0;
                valuesTimeTwo++;
                labelTwo.Text = $"{valuesTimeTwo.ToString()}";
            }
        }

        private void CourseOfSeconds(ref int valuesTime, Label label)
        {
            if (valuesTime < 9)
            {
                valuesTime++;
                label.Text = $"0{valuesTime.ToString()}";
            }
            else
            {
                valuesTime++;
                label.Text = valuesTime.ToString();
            }
        }
    }
}
