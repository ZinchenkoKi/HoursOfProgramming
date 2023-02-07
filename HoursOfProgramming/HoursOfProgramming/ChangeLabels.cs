using System;

namespace HoursOfProgramming
{
    internal class ChangeLabels
    {
        internal void OutputOfTotalHours(TimeInFile timeInFile, Label allHours)
        {
            PathFile path = new PathFile();
            ProcessingIndicators processing = new ProcessingIndicators();
            processing.ReadingFile(timeInFile, path.GettingFilePath());
            allHours.Text = timeInFile.hoursInFile.ToString();
        }

        internal void ResetMeaning(Label labelOne)
        {
            labelOne.Text = "00";
        }

        internal void UpTen(Label label, int valuesTime)
        {
            label.Text = $"0{valuesTime.ToString()}";
        }

        internal void AfterTen(Label label, int valuesTime)
        {
            label.Text = $"{valuesTime.ToString()}";
        }
    }
}
