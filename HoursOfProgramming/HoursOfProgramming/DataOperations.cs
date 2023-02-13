using System;

namespace HoursOfProgramming
{
    public class DataOperations
    {
        public  TimeInFile DataConversion(TimeInFile timeInFile)
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
