namespace Extractor.WpfClient.Exporters
{
    using System;
    using System.Collections.Generic;
    using Extractor.WpfClient.Contracts;
    using System.IO;

    public class TxtExporter : IExporter
    {
        public void Export<T>(
            ICollection<T> fileInformations, 
            string folderToExportTo, 
            string fileName) where T: IFileInfo
        {
            string fullExportFilePath = (folderToExportTo + "\\" + fileName + ".txt").Replace("\\\\", "\\");

            //try
            //{
                StreamWriter writer = new StreamWriter(fullExportFilePath);
                using (writer)
                {
                    foreach (var fileInfo in fileInformations)
                    {
                        writer.WriteLine(fileInfo.ToString());
                    }
                }
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
        }
    }
}
