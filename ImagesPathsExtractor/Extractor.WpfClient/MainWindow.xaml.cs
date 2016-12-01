namespace Extractor.WpfClient
{
    using Contracts;
    using System.Windows;

    public partial class MainWindow : Window
    {
        private IDataContext mainWindowContext;

        public MainWindow()
        {
            InitializeComponent();

            this.mainWindowContext = new MainWindowDataContex();
        }
    }
}
