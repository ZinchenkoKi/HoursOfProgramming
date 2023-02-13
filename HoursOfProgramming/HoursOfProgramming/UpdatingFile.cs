using System;
using System.IO;

namespace HoursOfProgramming
{
    public class UpdatingFile
    {
        public void Update(TimeInFile timeInFile, TimeInApp timeInApp)
        {
            PathFile path = new PathFile();
            Reading reading = new Reading();
            RecalculationTime recalculationTime = new RecalculationTime();
            Writing writing = new Writing();
            DataOperations dataOperations = new DataOperations();

            string filePath = path.GettingPath();
            reading.ReadingFile(timeInFile, filePath);
            recalculationTime.Recalculation(timeInFile, timeInApp);
            writing.WritingFile(dataOperations.DataConversion(timeInFile), filePath);
        }
    }
}
