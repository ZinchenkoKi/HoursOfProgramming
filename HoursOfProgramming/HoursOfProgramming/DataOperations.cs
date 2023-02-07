using System;

namespace HoursOfProgramming
{
    internal class DataOperations
    {
        internal void SummationOfIndicators(TimeInFile timeInFile, TimeInApp timeInApp)
        {
            timeInFile.secondsInFile += timeInApp.secondsInApp;
            timeInFile.minutesInFile += timeInApp.minutesInApp;
            timeInFile.hoursInFile += timeInApp.hoursInApp;
        }

        internal  TimeInFile DataConversion(TimeInFile timeInFile)
        {
            if (timeInFile.secondsInFile > 59)
            {
                TimeTranslation(ref timeInFile.minutesInFile,ref timeInFile.secondsInFile);
            }
            if (timeInFile.minutesInFile > 59)
            {
                TimeTranslation(ref timeInFile.hoursInFile, ref timeInFile.minutesInFile);
            }
            return timeInFile;
        }

        private void TimeTranslation(ref int timeInFileOne, ref int timeInFileTwo)
        {
            timeInFileOne += timeInFileTwo / 60;
            timeInFileTwo = timeInFileTwo % 60;
        }
    }
}
