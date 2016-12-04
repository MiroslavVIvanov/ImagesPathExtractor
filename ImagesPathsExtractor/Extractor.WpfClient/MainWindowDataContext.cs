namespace Extractor.WpfClient
{
    using System;
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


        public MainWindowDataContex()
        {
            this.images = new List<ImageInfo>();
        }

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
                if (value == null)
                {
                    throw new ArgumentNullException("Import folder path can not be null");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("Import folder path can not be empty string");
                }

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
                if (value == null)
                {
                    throw new ArgumentNullException("Export file name can not be null");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("Export file name can not be empty string");
                }

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
                if (value == null)
                {
                    throw new ArgumentNullException("Export folder path can not be null");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("Export folder path can not be empty string");
                }

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
                if (value == null)
                {
                    throw new ArgumentNullException("The ImageInfo collection can not be null");
                }

                if (value.Count == 0)
                {
                    throw new ArgumentNullException("The ImageInfo collection can not be empty");
                }

                this.images = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
