using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursOfProgramming
{
    internal class Path
    {
        private string fileWithPath = @"E:\Projects\HoursOfProgramming\HoursOfProgramming\HoursOfProgramming\FilePath.txt";
        internal string GettingFilePath()
        {
            using (StreamReader sr = new StreamReader(fileWithPath))
            {
                string path = sr.ReadToEnd();
                return path;
            }
        }
    }
}
