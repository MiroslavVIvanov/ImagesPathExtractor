namespace Extractor.Dialoger
{
    using System;
    using System.Windows.Forms;

    public class DialogOpener
    {
        private string defaultFolderPath;

        public DialogOpener(string folderPathWhenSelectionNotSuccessful = null)
        {
            this.DefaultFolderPath = folderPathWhenSelectionNotSuccessful;
        }

        public string DefaultFolderPath
        {
            get
            {
                return defaultFolderPath;
            }

            set
            {
                defaultFolderPath = value;
            }
        }

        public string ShowFolderPickerDialog(string defaultFolderPath = null)
        {
            FolderBrowserDialog fDialog = new FolderBrowserDialog();
            fDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            if (!(fDialog.ShowDialog() == DialogResult.OK))
            {
                return this.DefaultFolderPath;
            }

            return fDialog.SelectedPath.ToString();
                //.Replace('\\', '/') + "/";
        }
    }
}
