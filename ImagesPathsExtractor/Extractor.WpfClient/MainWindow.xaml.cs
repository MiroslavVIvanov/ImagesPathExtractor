namespace Extractor.WpfClient
{
    using System.IO;
    using System.Windows;
    using Dialoger;
    using Common;
    using Models;
    using System.Threading.Tasks;
    using System.Drawing;
    using Exporters;
    using Contracts;

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

                ImageInfo[] images = new ImageInfo[paths.Length];

                Parallel.For(0, images.Length, i =>
                {
                    using (Bitmap image = new Bitmap(paths[i]))
                    {
                        images[i] = new ImageInfo(
                            paths[i],
                            image.Height,
                            image.Width,
                            image.VerticalResolution,
                            image.HorizontalResolution);
                    }
                });

                this.context.Images = images;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        private void ExportToTxtBtnClicked(object sender, RoutedEventArgs e)
        {
            IExporter exporter = new TxtExporter();
            exporter.Export(this.context.Images, this.context.ExportFolderPath, this.context.ExportFileName);
        }
    }
}
