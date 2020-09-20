using System.Drawing;
using System.Windows.Forms;
using Lab2.Constants;

namespace lab3_CV
{
    public static class Selector
    {
        public static Bitmap SelectImage()
        {
            var fileDialog = new OpenFileDialog()
            {
                Filter = FileTypeRegexes.ImageTypesRegexes
            };
            return fileDialog.ShowDialog() == DialogResult.OK
                ? Image.FromFile(fileDialog.FileName) as Bitmap
                : null;
        }
        public static Color SelectColor()
        {
            var dialog = new ColorDialog();
            return dialog.ShowDialog() == DialogResult.Cancel ? Color.Empty : dialog.Color;
        }
    }
}