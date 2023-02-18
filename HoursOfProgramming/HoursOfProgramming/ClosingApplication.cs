namespace HoursOfProgramming
{
    public class ClosingApplication
    {
        SavingMetrics metrics = new SavingMetrics();
        PathFile.Path path = new PathFile.Path();
        public void Close(TimeInFile timeInFile, TimeInApp timeInApp)
        { 
            metrics.Save(timeInFile, timeInApp, path.GettingPath());
            Application.Exit();
        }
    }
}
