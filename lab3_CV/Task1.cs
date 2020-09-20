using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab3_CV
{
    public partial class Task1 : Form
    {
        //Task2 task2;
        private readonly Graphics _lineDrawer;
        private Bitmap _image;
        private Point _lastCursorCoordinates;
        private readonly Pen _borderPen = Pens.CadetBlue;

        public Task1()
        {
            InitializeComponent();
            /*
            task2 = new Task2()
            {
                Owner = this
            };
            task2.Show();
            */
            imageContainer.Image = new Bitmap(imageContainer.Width, imageContainer.Height);
            _lineDrawer = Graphics.FromImage(imageContainer.Image);
        }

        private void imageContainer_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    _lastCursorCoordinates = e.Location;
                    break;
                case MouseButtons.Right:
                    {
                        var currentPosition = new Point(e.X, e.Y);
                        var canvas = imageContainer.Image as Bitmap;
                        var filler = _image == null
                            ? (IFloodFiller)ColorFourWayFloodFiller.GetInstance(Selector.SelectColor())
                            : ImageFourWayFloodFiller.GetInstance(_image);
                        filler.FillByLines(canvas, currentPosition, _borderPen.Color);
                        imageContainer.Refresh();
                        break;
                    }
            }
        }

        private void imageContainer_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _lastCursorCoordinates = e.Location;
        }

        private void imageContainer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (_lastCursorCoordinates == e.Location) return;
            _lineDrawer.DrawLine(_borderPen, _lastCursorCoordinates, e.Location);
            imageContainer.Refresh();
            _lastCursorCoordinates = e.Location;
        }

        private void imageLoadingButton_Click(object sender, EventArgs e)
        {
            _image = Selector.SelectImage();
        }
    }
}
