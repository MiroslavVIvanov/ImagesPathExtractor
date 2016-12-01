namespace Extractor.WpfClient
{
    using System.ComponentModel;
    using Contracts;
    using Common;
    using System.Windows.Forms;
    using System;

    public class MainWindowDataContex : IDataContext, INotifyPropertyChanged
    {
        private string importFolderPath;
        private string exportFileName;
        private string exportFolderPath;

        public string ImportFolderPath
        {
            get
            {
                if (this.importFolderPath == null)
                {
                    return Constants.DefaultImportFolderPath;
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
                    return Constants.DefaultExportFileName;
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
                    return Constants.DefaultExportFolderPath;
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
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
