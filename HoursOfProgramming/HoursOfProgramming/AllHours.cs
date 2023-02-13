using System;

namespace HoursOfProgramming
{
    public class AllHours
    {
        public void OutputOfTotalHours(TimeInFile timeInFile, Label allHours)
        {
            PathFile path = new PathFile();
            Reading reading = new Reading();
            reading.ReadingFile(timeInFile, path.GettingPath());
            allHours.Text = timeInFile.hoursInFile.ToString();
        }
    }
}
