using System;
using System.IO;

namespace HoursOfProgramming
{
    internal class ProcessingIndicators
    {
        internal void ProcessingData(TimeInFile timeInFile, TimeInApp timeInApp)
        {
            DataOperations dataOperations = new DataOperations();
            Path path = new Path();
            string filePath = path.GettingFilePath();
            ReadingFile(timeInFile, filePath);
            dataOperations.SummationOfIndicators(timeInFile, timeInApp);
            WritingFile(dataOperations.DataConversion(timeInFile), filePath);
        }

        internal void ReadingFile(TimeInFile timeInFile, string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                timeInFile.hoursInFile = Convert.ToInt32(reader.ReadLine());
                timeInFile.minutesInFile = Convert.ToInt32(reader.ReadLine());
                timeInFile.secondsInFile = Convert.ToInt32(reader.ReadLine());
            }
        }

        private void WritingFile(TimeInFile timeInFile, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(timeInFile.hoursInFile);
                writer.WriteLine(timeInFile.minutesInFile);
                writer.WriteLine(timeInFile.secondsInFile);
            }
        }
    }
}
