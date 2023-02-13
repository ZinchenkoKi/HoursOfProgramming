using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursOfProgramming
{
    public class ChangingText
    {
        public void ChangingButtonText(Button button)
        {
            if (button.Text == "START")
            {
                button.Text = "STOP";
            }
            else
            {
                button.Text = "START";
            }
        }
    }
}
