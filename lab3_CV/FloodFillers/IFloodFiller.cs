using System.Drawing;

namespace lab3_CV
{
    public interface IFloodFiller
    {
        void FillByLines(Bitmap canvas, Point pixelCoordinates, Color borderColor);
    }
}