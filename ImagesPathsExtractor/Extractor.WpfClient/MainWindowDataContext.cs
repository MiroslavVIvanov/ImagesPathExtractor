namespace Extractor.WpfClient
{
    using System.ComponentModel;
    using Contracts;

    public class MainWindowDataContex : IDataContext, INotifyPropertyChanged
    {
        private const string DefaultImportFolderPath = @"C:\BBB";
        private const string DefaultExportFileName = "ImagesPaths";
        private const string DefaultExportFolderPath = @"C:\BBB";

        private string importFolderPath;
        private string exportFileName;
        private string exportFolderPath;

        public string ImportFolderPath
        {
            get
            {
                if (this.importFolderPath == null)
                {
                    return DefaultImportFolderPath;
                }

                return this.importFolderPath;
            }

            set
            {
                //todo: validation of the folder path
                this.importFolderPath = value;
                OnPropertyChanged("ImportFolderPath");
            }
        }

        public string ExportFileName
        {
            get
            {
                if (this.exportFileName == null)
                {
                    return DefaultExportFileName;
                }

                return this.exportFileName;
            }

            set
            {
                //todo: validation
                this.exportFileName = value;
                OnPropertyChanged("ExportFileName");
            }
        }

        public string ExportFolderPath
        {
            get
            {
                if (this.exportFolderPath == null)
                {
                    return DefaultExportFolderPath;
                }

                return this.exportFolderPath;
            }

            set
            {
                //todo: validation
                this.exportFolderPath = value;
                OnPropertyChanged("ExportFolderPath");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        //public event PropertyChangedEventHandler PropertyChanged;

        //public void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
