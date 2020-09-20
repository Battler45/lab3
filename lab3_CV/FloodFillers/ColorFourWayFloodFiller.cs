using System.Drawing;

namespace lab3_CV
{
    public sealed class ColorFourWayFloodFiller: FourWayFloodFiller
    {
        private Color FillerColor { get; }
        private ColorFourWayFloodFiller(Color fillerColor)
        {
            FillerColor = fillerColor;
        }
        public static ColorFourWayFloodFiller GetInstance(Color fillerColor) => new ColorFourWayFloodFiller(fillerColor);
        protected override bool IsSuitablePixel(Bitmap canvas, Point pixelCoordinates, Color borderColor)
        {
            if (!canvas.IsCorrectPixelCoordinates(pixelCoordinates)) return false;
            var pixelColor = canvas.GetPixel(pixelCoordinates.X, pixelCoordinates.Y);
            return !pixelColor.Equal(borderColor) && !pixelColor.Equal(FillerColor);
        }
        protected override void DrawLine(Bitmap canvas, HorizontalLine line)
        {
            Easel.GetInstance(canvas).Graphics.DrawLine(new Pen(FillerColor), line.Begin, line.End);
        }
    }
}