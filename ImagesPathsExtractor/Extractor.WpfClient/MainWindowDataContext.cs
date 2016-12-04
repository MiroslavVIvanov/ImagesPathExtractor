namespace Extractor.WpfClient
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using Common;
    using Contracts;
    using Models;

    public class MainWindowDataContex : IDataContext, INotifyPropertyChanged
    {
        private string importFolderPath;
        private string exportFileName;
        private string exportFolderPath;

        private ICollection<ImageInfo> images;

        private bool areExportButtonsAvailable;

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

        public ICollection<ImageInfo> Images
        {
            get
            {
                return this.images;
            }

            internal set
            {
                this.images = value;

                if (this.images != null && this.images.Count > 0)
                {
                    this.AreExportButtonsAvailable = true;
                }
                else
                {
                    this.AreExportButtonsAvailable = false;
                }
            }
        }

        public bool AreExportButtonsAvailable
        {
            get
            {
                return this.areExportButtonsAvailable;
            }

            set
            {
                this.areExportButtonsAvailable = value;
                OnPropertyChanged("AreExportButtonsAvailable");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
