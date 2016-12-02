using System.Collections.Generic;

namespace Extractor.WpfClient.Contracts
{
    public interface IExporter
    {
        void Export(ICollection<IFileInfo> collectionOfFileInformationToExport);
    }
}
