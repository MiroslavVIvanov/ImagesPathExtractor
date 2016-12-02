using Extractor.WpfClient.Contracts;

namespace Extractor.WpfClient.Models
{
    public class ImageInfo: IFileInfo
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
            this.FullPath = fullPath;
            this.ImageHeight = imageHeight;
            this.ImageWidth = imageWidth;
            this.VerticalResolution = verticalResolution;
            this.HorizontalResolution = horizontalResolution;
        }

        public string FullPath
        {
            get
            {
                return fullPath;
            }

            set
            {
                fullPath = value;
            }
        }

        public int ImageHeight
        {
            get
            {
                return imageHeight;
            }

            set
            {
                imageHeight = value;
            }
        }

        public int ImageWidth
        {
            get
            {
                return imageWidth;
            }

            set
            {
                imageWidth = value;
            }
        }

        public float VerticalResolution
        {
            get
            {
                return verticalResolution;
            }

            set
            {
                verticalResolution = value;
            }
        }

        public float HorizontalResolution
        {
            get
            {
                return horizontalResolution;
            }

            set
            {
                horizontalResolution = value;
            }
        }
    }
}
