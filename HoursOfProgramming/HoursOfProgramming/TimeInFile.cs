namespace HoursOfProgramming
{
    public class TimeInFile 
    {
        public int HoursInFile { get; set; }
        public int MinutesInFile { get; set; }
        public int SecondsInFile { get; set; }

        public TimeInFile()
        {

        }

        public TimeInFile(int HoursInFile, int MinutesInFile, int SecondsInFile )
        {
            this.HoursInFile = HoursInFile;
            this.MinutesInFile = MinutesInFile;
            this.SecondsInFile = SecondsInFile;
        }
    }
}
