using System;

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
