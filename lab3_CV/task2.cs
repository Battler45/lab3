using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab3_CV
{
    public partial class Task2 : Form
    {
        private Graphics _graphics;
        private Point _previousCursorPosition = Point.Empty;
        private readonly Pen _pen = new Pen(Color.Black, 15);
        private Color _borderColor = Color.Empty;

        public Task2()
        {
            InitializeComponent();
            imageContainer.Visible = imageContainer.Enabled = false;
        }

        private void imageLoadingButton_Click(object sender, EventArgs e)
        {
            var selectedImage = Selector.SelectImage();
            if (selectedImage == null) return;
            imageContainer.Image = selectedImage;
            _graphics = Graphics.FromImage(selectedImage);

            imageLoadingButton.Enabled = imageLoadingButton.Visible = false;
            imageContainer.Visible = imageContainer.Enabled = true;
            MessageBox.Show($"Зажатой левой клавишей мыши можно выделить границу{Environment.NewLine}Первым нажатием правой клавиши мыши мы указываем цвет границ{Environment.NewLine}Вторым нажатием указываем область");
        }

        private void imageContainer_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (!(imageContainer.Image is Bitmap image)) throw new ArgumentNullException($"{nameof(imageContainer.Image)} is empty(null)");
            if (Color.Empty == _borderColor)
            {
                _borderColor = image.GetColor(e.Location);
                return;
            }
            var borderPixelCoordinates = image.FindCoordinatesOfPixelWithColor(e.Location, _borderColor) ?? throw new ArgumentException("Пиксель с данным цветом не обнаружен");
            var areaBorder = BorderFinder.GetInstance().FindBorder(image, borderPixelCoordinates, _borderColor);
            _graphics.DrawLines(Pens.Red, areaBorder.ToArray());
            imageContainer.Refresh();
        }

        private void imageContainer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _graphics.DrawLine(_pen, _previousCursorPosition, e.Location);
            imageContainer.Refresh();
            _previousCursorPosition = e.Location;
        }

        private void imageContainer_MouseDown(object sender, MouseEventArgs e) =>  _previousCursorPosition = e.Location;
    }
}
