using Extractor.WpfClient.Contracts;
using System.Text;

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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(
                "{0}\t{1}\t{2}\t{3}\t{4}\t", 
                this.FullPath, 
                this.ImageHeight, 
                this.ImageWidth, 
                this.VerticalResolution, 
                this.HorizontalResolution);

            return sb.ToString();
        }
    }
}
