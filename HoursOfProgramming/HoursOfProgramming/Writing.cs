using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursOfProgramming
{
    public class Writing
    {
        public void WritingFile(TimeInFile timeInFile, string path)
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
