using System;
using System.IO;
using Avalonia;
using Avalonia.Media.Imaging;
using SixLabors.ImageSharp;

namespace Paint.ViewModels
{
    public class ImageViewModel : ViewModelBase, IDisposable
    {
        private readonly Image _image;
        private Bitmap? _bitmap;
        private Rect _bounds;

        private ImageViewModel(Image image)
        {
            _image = image;
            Invalidate();
        }

        public double Width => _image.Width;

        public double Height => _image.Height;

        public Image Image => _image;

        public Bitmap? Bitmap => _bitmap;

        public Rect Bounds => _bounds;

        public static ImageViewModel Create(string path)
        {
            return new(Image.Load(path));
        }

        public void Invalidate()
        {
            _bitmap?.Dispose();

            using var stream = new MemoryStream();
            _image.SaveAsBmp(stream);
            stream.Position = 0;
            _bitmap = new Bitmap(stream);
            _bounds = new Rect(0, 0, _image.Width, _image.Height);
        }

        public void Dispose()
        {
            _image.Dispose();
            _bitmap?.Dispose();
        }
    }
}
