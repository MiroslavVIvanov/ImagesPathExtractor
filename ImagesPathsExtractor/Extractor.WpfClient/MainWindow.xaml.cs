namespace Extractor.WpfClient
{
    using System.IO;
    using System.Windows;
    using Dialoger;
    using Common;

    public partial class MainWindow : Window
    {
        private MainWindowDataContex context;

        private DialogShower dialogger;

        public MainWindow()
        {
            InitializeComponent();
            this.context = new MainWindowDataContex();
            this.DataContext = this.context;

            this.dialogger = new DialogShower();
        }

        private void BrowseImagesFolderClicked(object sender, RoutedEventArgs e)
        {
            context.ImportFolderPath = dialogger.ShowFolderPickerDialog();
        }

        private void BrowseExportFolderClicked(object sender, RoutedEventArgs e)
        {
            context.ExportFolderPath = dialogger.ShowFolderPickerDialog();
        }

        private void ExtractPathsButtonClick(object sender, RoutedEventArgs e)
        {
            var imagesFolderPath = this.context.ImportFolderPath.Replace('\\', '/') + "/";
            try
            {
                string[] paths = Directory.GetFiles(
                    imagesFolderPath, 
                    Constants.DefaultImageExtension, 
                    SearchOption.AllDirectories);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
    }
}
