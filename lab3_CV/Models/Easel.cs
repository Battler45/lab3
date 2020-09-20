using System.Drawing;

namespace lab3_CV
{
    public class Easel
    {
        public Bitmap Canvas { get; }
        public Graphics Graphics { get; }

        private Easel(Bitmap canvas)
        {
            Canvas = canvas;
            Graphics = Graphics.FromImage(canvas);
        }
        public static Easel GetInstance(Bitmap canvas) => new Easel(canvas);
    }
}