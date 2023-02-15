using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursOfProgramming
{
    public class ChangingFile
    {
        public void ReadingFile(TimeInFile timeInFile, string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                timeInFile.HoursInFile = Convert.ToInt32(reader.ReadLine());
                timeInFile.MinutesInFile = Convert.ToInt32(reader.ReadLine());
                timeInFile.SecondsInFile = Convert.ToInt32(reader.ReadLine());
            }
        }

        public void WritingFile(TimeInFile timeInFile, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(timeInFile.HoursInFile);
                writer.WriteLine(timeInFile.MinutesInFile);
                writer.WriteLine(timeInFile.SecondsInFile);
            }
        }

        public TimeInFile UpdatingCounter(TimeInFile timeInFile)
        {
            if (timeInFile.SecondsInFile > 59)
            {
                timeInFile.MinutesInFile += timeInFile.SecondsInFile / 60;
                timeInFile.SecondsInFile = timeInFile.SecondsInFile % 60;
            }
            else if (timeInFile.MinutesInFile > 59)
            {
                timeInFile.HoursInFile += timeInFile.MinutesInFile / 60;
                timeInFile.MinutesInFile = timeInFile.MinutesInFile % 60;
            }
            return timeInFile;
        }
    }
}
