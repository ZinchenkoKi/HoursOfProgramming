using System;
using System.IO;
using System.Text;

namespace HoursOfProgramming
{
    internal class PathFile
    {
       
        internal string GettingFilePath()
        {
            string baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string appStorageFolder = Path.Combine(baseFolder, "StopwatchData.txt");
            if (CheckingForExistence(appStorageFolder))
            {
                return appStorageFolder;
            }
            else
            {
                CreateFile(appStorageFolder, baseFolder);
                return appStorageFolder;
            }
        }

        private bool CheckingForExistence(string appStorageFolder)
        {
            FileInfo fileInfo = new FileInfo(appStorageFolder);
            if (fileInfo.Exists)
            {
                return true;
            }
            return false;
        }

        private void CreateFile(string appStorageFolder,string baseFolder)
        {
            using (FileStream file = File.Create(appStorageFolder))
            { 
            }
            MessageBox.Show($"В папке -> {baseFolder} был создан файл StopwatchData.txt");
        }
    }
}
