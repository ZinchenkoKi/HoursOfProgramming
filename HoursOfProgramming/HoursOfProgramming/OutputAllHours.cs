using System;

namespace HoursOfProgramming
{
    public class OutputAllHours
    {
        public void Output(TimeInFile timeInFile, Label allHours)
        {
            PathFile.Path path = new PathFile.Path();
            ChangingFile reading = new ChangingFile();
            reading.ReadingFile(timeInFile, path.GettingPath());
            allHours.Text = timeInFile.HoursInFile.ToString();
        }
    }
}
