using System.Drawing;

namespace lab3_CV
{
    public static class ColorExtensions
    {
        public static bool Equal(this Color color, Color anotherColor)
            => color.R == anotherColor.R
               && color.G == anotherColor.G
               && color.B == anotherColor.B
        ;
    }
}