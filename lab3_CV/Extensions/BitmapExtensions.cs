using System.Drawing;

namespace lab3_CV
{
    public static class BitmapExtensions
    {
        public static Color GetColor(this Bitmap image, Point pixelCoordinates)
            => image.GetPixel(pixelCoordinates.X, pixelCoordinates.Y);

        public static Point? FindCoordinatesOfPixelWithColor(this Bitmap bmp, Point neighborPoint, Color color)
        {
            if (!bmp.IsCorrectPixelCoordinates(neighborPoint)) return null;
            while (bmp.GetPixel(neighborPoint.X, neighborPoint.Y) != color)
            {
                neighborPoint.Offset(1, 0);
                if (neighborPoint.X >= bmp.Width) return null;
            }
            return neighborPoint;
        }
    }
}