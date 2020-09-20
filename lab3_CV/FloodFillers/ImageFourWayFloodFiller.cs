using System.Drawing;

namespace lab3_CV
{
    public sealed class ImageFourWayFloodFiller : FourWayFloodFiller
    {
        private readonly bool[,] _used;
        private readonly Bitmap _image;

        private ImageFourWayFloodFiller(Bitmap image)
        {
            _image = image;
            _used = new bool[image.Width, image.Height];
        }

        public static ImageFourWayFloodFiller GetInstance(Bitmap image) => new ImageFourWayFloodFiller(image);

        protected override bool IsSuitablePixel(Bitmap canvas, Point pixelCoordinates, Color borderColor)
        {
            if (!_image.IsCorrectPixelCoordinates(pixelCoordinates) 
                || !canvas.IsCorrectPixelCoordinates(pixelCoordinates)) 
                return false;
            var pixelColor = canvas.GetPixel(pixelCoordinates.X, pixelCoordinates.Y);
            return !pixelColor.Equal(borderColor) && !_used[pixelCoordinates.X, pixelCoordinates.Y];
        }

        protected override void DrawLine(Bitmap canvas, HorizontalLine line)
        {
            if (line.Y > _image.Height) return;
            var drawningLine = line.Cut(0, _image.Width);

            for (var i = drawningLine.BeginX; i < drawningLine.EndX && i < _image.Width; i++)
                _used[i, drawningLine.Y] = true;

            for (var i = drawningLine.BeginX; i < drawningLine.EndX; i++)
                if (i < _image.Width && drawningLine.Y < _image.Height)
                    canvas.SetPixel(i, drawningLine.Y, _image.GetPixel(i, drawningLine.Y));
        }
    }
}