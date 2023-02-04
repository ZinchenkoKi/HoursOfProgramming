namespace HoursOfProgramming
{
    public partial class Form1 : Form
    {
        StartingTimer startingTimer = new StartingTimer();
        StopwatchOperation stopwatchOperation = new StopwatchOperation();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingTimer.ActivationButton(timer1,button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stopwatchOperation.StopwatchProcess(label3,label2, label1);
        }
    }
}