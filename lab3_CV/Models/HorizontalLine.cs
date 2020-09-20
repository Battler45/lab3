using System;
using System.Drawing;

namespace lab3_CV
{
    public struct HorizontalLine
    {
        public HorizontalLine(Point begin, Point end)
        {
            if (begin.Y != end.Y || begin.X > end.X)
            {
                throw new ArgumentException();
            }
            BeginX = begin.X;
            EndX = end.X;
            Y = begin.Y;
        }
        private HorizontalLine(int beginX, int endX, int y)
        {
            BeginX = beginX;
            EndX = endX;
            Y = y;
        }

        public int BeginX { get; set; }
        public int EndX { get; set; }
        public int Y { get; set; }
        public Point Begin => new Point(BeginX, Y);
        public Point End => new Point(EndX, Y);

        public HorizontalLine Cut(int beginX, int endX)
        {
            if (beginX > endX)
            {
                throw new ArgumentException();
            }
            return new HorizontalLine(Math.Max(BeginX, beginX), Math.Min(EndX, endX), Y);
        }
    }
}