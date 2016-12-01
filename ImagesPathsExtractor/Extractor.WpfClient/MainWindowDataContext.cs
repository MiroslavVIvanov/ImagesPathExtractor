namespace Extractor.WpfClient
{
    using System.ComponentModel;
    using Contracts;

    public class MainWindowDataContex : IDataContext, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
