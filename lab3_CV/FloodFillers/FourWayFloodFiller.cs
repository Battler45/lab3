using System.Drawing;

namespace lab3_CV
{
    public abstract class FourWayFloodFiller: IFloodFiller
    {
        public void FillByLines(Bitmap canvas, Point pixelCoordinates, Color borderColor)
        {
            if (!IsSuitablePixel(canvas, pixelCoordinates, borderColor)) return;
            var leftBorder = FindLeftBorder(pixelCoordinates, canvas, borderColor);
            var rightBorder = FindRightBorder(pixelCoordinates, canvas, borderColor);
            DrawLine(canvas, new HorizontalLine(leftBorder, rightBorder));
            for (var i = leftBorder.X; i < rightBorder.X; i++)
                FillByLines(canvas, new Point(i, pixelCoordinates.Y + 1), borderColor);
            for (var i = leftBorder.X; i < rightBorder.X; i++)
                FillByLines(canvas, new Point(i, pixelCoordinates.Y - 1), borderColor);
        }
        private static Point FindLeftBorder(Point currentPosition, Bitmap canvas, Color borderColor)
        {
            var temp_x = currentPosition.X;
            while (temp_x > 0)
            {
                var currentColor = canvas.GetPixel(temp_x, currentPosition.Y);
                if (!currentColor.Equal(borderColor))
                    temp_x--;
                else
                {
                    temp_x++;
                    break;
                }
            }
            return new Point(temp_x, currentPosition.Y);
        }
        private static Point FindRightBorder(Point currentPosition, Bitmap canvas, Color borderColor)
        {
            var temp_x = currentPosition.X;
            while (temp_x < canvas.Width)
            {
                var currentColor = canvas.GetPixel(temp_x, currentPosition.Y);
                if (!currentColor.Equal(borderColor))
                    temp_x++;
                else
                {
                    temp_x--;
                    break;
                }
            }
            return new Point(temp_x, currentPosition.Y);
        }

        protected abstract bool IsSuitablePixel(Bitmap canvas, Point pixelCoordinates, Color borderColor);
        protected abstract void DrawLine(Bitmap canvas, HorizontalLine line);

    }
}