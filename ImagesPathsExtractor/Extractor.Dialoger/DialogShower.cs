namespace Extractor.Dialoger
{
    using System;
    using System.Windows.Forms;

    public class DialogShower
    {
        private string defaultFolderPath;

        public DialogShower(string folderPathWhenSelectionNotSuccessful = null)
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
