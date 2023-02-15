using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursOfProgramming
{
    
    public class SavingMetrics
    {
        ChangingFile changingFile = new ChangingFile();

        public void Save(TimeInFile timeInFile, TimeInApp timeInApp, string path)
        {
            changingFile.ReadingFile(timeInFile, path); 
            Sum(timeInFile, timeInApp);
            changingFile.UpdatingCounter(timeInFile);
            changingFile.WritingFile(timeInFile, path);
        }

        private TimeInFile Sum(TimeInFile timeInFile, TimeInApp timeInApp)
        {
            timeInFile.SecondsInFile += timeInApp.SecondsInApp;
            timeInFile.MinutesInFile += timeInApp.MinutesInApp;
            timeInFile.HoursInFile += timeInApp.HoursInApp;
            return timeInFile;
        }
    }
}
