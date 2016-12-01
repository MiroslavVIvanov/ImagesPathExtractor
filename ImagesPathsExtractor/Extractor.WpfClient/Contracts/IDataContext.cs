namespace Extractor.WpfClient.Contracts
{
    using System.ComponentModel;

    public interface IDataContext : INotifyPropertyChanged
    {
        void OnPropertyChanged(string propertyName);
    }
}
