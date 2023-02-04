using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HoursOfProgramming
{
    internal class StartingTimer
    {
        internal void ActivationButton(System.Windows.Forms.Timer timer, Button button)
        {
            ChangingButtonText(button);
            ActivatingTimer(timer, button);
        }

        private void ChangingButtonText(Button button)
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

        private void ActivatingTimer(System.Windows.Forms.Timer timer, Button button)
        {
            if (button.Text == "START")
            {
              timer.Enabled = false;
            }
            else
            {
              timer.Enabled = true;
            }
        }
    }
}
