using System;

namespace HoursOfProgramming
{
    public class StartingTimer
    {
        public void Start(System.Windows.Forms.Timer timer, Button button)
        {
            ChangingText changingText = new ChangingText();

            changingText.ChangingButtonText(button);
            CheckingForActivity(timer, button);
        }

        private void CheckingForActivity(System.Windows.Forms.Timer timer, Button button)
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
