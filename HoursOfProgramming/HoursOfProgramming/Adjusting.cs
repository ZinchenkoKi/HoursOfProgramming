using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursOfProgramming
{
    public class Adjusting
    {
        public void AdjustingIndicators(ref int valuesTimeOne, ref int valuesTimeTwo, Label labelOne)
        {
            valuesTimeOne = 0;
            valuesTimeTwo++;
            ResetMeaning(labelOne);
        }

        private void ResetMeaning(Label labelOne)
        {
            labelOne.Text = "00";
        }
    }
}
