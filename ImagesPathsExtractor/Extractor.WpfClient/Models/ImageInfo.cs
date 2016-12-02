namespace Extractor.WpfClient.Models
{
    public class ImageInfo
    {
        private string fullPath;

        private int imageHeight;
        private int imageWidth;

        private float verticalResolution;
        private float horizontalResolution;

        public ImageInfo(
            string fullPath, 
            int imageHeight, 
            int imageWidth, 
            float verticalResolution, 
            float horizontalResolution)
        {
            this.fullPath = fullPath;
            this.imageHeight = imageHeight;
            this.imageWidth = imageWidth;
            this.verticalResolution = verticalResolution;
            this.horizontalResolution = horizontalResolution;
        }
    }
}
