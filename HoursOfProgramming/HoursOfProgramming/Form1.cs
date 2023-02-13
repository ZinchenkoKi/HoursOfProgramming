using System;

namespace HoursOfProgramming
{
    public partial class Form1 : Form
    {
        AllHours allHours = new AllHours();
        TimeInFile timeInFile = new TimeInFile();
        StartingTimer startingTimer = new StartingTimer();
        StopwatchOperation stopwatchOperation = new StopwatchOperation();
        TimeInApp timeInApp = new TimeInApp();
        UpdatingFile updatingFile = new UpdatingFile();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allHours.OutputOfTotalHours(timeInFile, label7);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingTimer.Start(timer1,button1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stopwatchOperation.Tick(timeInApp, label3, label2, label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updatingFile.Update(timeInFile, timeInApp);
            this.Close();
        }
    }
}