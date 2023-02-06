using System;

namespace HoursOfProgramming
{
    public partial class Form1 : Form
    {
        StartingTimer startingTimer = new StartingTimer();
        StopwatchOperation stopwatchOperation = new StopwatchOperation();
        TimeInFile timeInFile = new TimeInFile();
        TimeInApp timeInApp = new TimeInApp();
        ProcessingIndicators processingIndicators = new ProcessingIndicators();
        ChangeLabels changeLabels = new ChangeLabels();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            changeLabels.OutputOfTotalHours(timeInFile, label7);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingTimer.ActivationButton(timer1,button1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stopwatchOperation.StopwatchProcess(timeInApp, label3, label2, label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            processingIndicators.ProcessingData(timeInFile, timeInApp);
            this.Close();
        }

    }
}