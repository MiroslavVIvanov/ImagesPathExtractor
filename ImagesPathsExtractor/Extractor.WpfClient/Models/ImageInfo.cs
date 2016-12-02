namespace Extractor.WpfClient.Models
{
    public class ImageInfo
    {
        private string fullPath;

        private int imageHeight;
        private int imageWidth;

        private int verticalResolution;
        private int horizontalResolution;

        public ImageInfo(
            string fullPath, 
            int imageHeight, 
            int imageWidth, 
            int verticalResolution, 
            int horizontalResolution)
        {
            this.fullPath = fullPath;
            this.imageHeight = imageHeight;
            this.imageWidth = imageWidth;
            this.verticalResolution = verticalResolution;
            this.horizontalResolution = horizontalResolution;
        }
    }
}
