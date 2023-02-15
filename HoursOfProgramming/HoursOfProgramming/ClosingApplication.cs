using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursOfProgramming
{
    public class ClosingApplication
    {
        SavingMetrics metrics = new SavingMetrics();
        PathFile pathFile = new PathFile();
        public void Close(TimeInFile timeInFile, TimeInApp timeInApp)
        {
            metrics.Save(timeInFile, timeInApp, pathFile.GettingPath());
            Application.Exit();
        }
    }
}
