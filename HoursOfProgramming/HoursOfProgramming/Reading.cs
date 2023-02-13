using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursOfProgramming
{
    public class Reading
    {
        public void ReadingFile(TimeInFile timeInFile, string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                timeInFile.hoursInFile = Convert.ToInt32(reader.ReadLine());
                timeInFile.minutesInFile = Convert.ToInt32(reader.ReadLine());
                timeInFile.secondsInFile = Convert.ToInt32(reader.ReadLine());
            }
        }
    }
}
