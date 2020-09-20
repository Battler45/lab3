using System.Drawing;

namespace lab3_CV
{
    public static class ImageExtensions
    {
        public static bool IsCorrectPixelCoordinates(this Image image, Point pixelCoordinates)
            => pixelCoordinates.X >= 0 && pixelCoordinates.X < image.Width
                                       && pixelCoordinates.Y >= 0 && pixelCoordinates.Y < image.Height;

    }
}