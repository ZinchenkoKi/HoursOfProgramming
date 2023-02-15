using System;

namespace HoursOfProgramming
{
    public partial class Form1 : Form
    {
        OutputAllHours allHours = new OutputAllHours();
        TimeInFile timeInFile = new TimeInFile();
        StartingTimer startingTimer = new StartingTimer();
        StopwatchTick tick = new StopwatchTick();
        TimeInApp timeInApp = new TimeInApp();
        ClosingApplication closingApplication = new ClosingApplication();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allHours.Output(timeInFile, label7);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingTimer.Start(timer1,button1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick.Tick(timeInApp, label1, label2, label3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            closingApplication.Close(timeInFile, timeInApp);
        }
    }
}