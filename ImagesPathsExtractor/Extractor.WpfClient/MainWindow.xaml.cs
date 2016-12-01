namespace Extractor.WpfClient
{
    using System.Windows;
    using Dialoger;

    public partial class MainWindow : Window
    {
        private MainWindowDataContex mainWindowContext;

        private DialogOpener dialogger;

        public MainWindow()
        {
            InitializeComponent();
            this.mainWindowContext = new MainWindowDataContex();
            this.DataContext = this.mainWindowContext;

            this.dialogger = new DialogOpener();
        }

        private void BrowseImagesFolderClicked(object sender, RoutedEventArgs e)
        {
            mainWindowContext.ImportFolderPath = dialogger.ShowFolderPickerDialog();
        }

        private void BrowseExportFolderClicked(object sender, RoutedEventArgs e)
        {
            mainWindowContext.ExportFolderPath = dialogger.ShowFolderPickerDialog();
        }
    }
}
