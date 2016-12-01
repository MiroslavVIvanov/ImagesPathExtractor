namespace Extractor.WpfClient
{
    using System;
    using System.Windows;
    using System.Windows.Forms;
    using Contracts;

    public partial class MainWindow : Window
    {
        private MainWindowDataContex mainWindowContext;

        public MainWindow()
        {
            InitializeComponent();
            this.mainWindowContext = new MainWindowDataContex();
            this.DataContext = this.mainWindowContext;
        }

        private void ImagesFolderBrowse(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fDialog = new FolderBrowserDialog();
            fDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            fDialog.SelectedPath = @"C:\BBB";
            if (fDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                mainWindowContext.ImportFolderPath = fDialog.SelectedPath.ToString().Replace('\\', '/') + "/";
            }

        }
    }
}
