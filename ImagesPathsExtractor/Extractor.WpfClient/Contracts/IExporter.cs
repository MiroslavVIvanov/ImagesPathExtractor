namespace Extractor.WpfClient.Contracts
{
    using System.Collections.Generic;

    public interface IExporter
    {
        void Export<T>(
                    ICollection<T> fileInformations,
                    string folderToExportTo,
                    string fileName) where T : IFileInfo;
    }
}
