using System;
using ReactiveUI;
using SixLabors.ImageSharp;

namespace Paint.ViewModels
{
    public class ImageViewModel : ViewModelBase, IDisposable
    {
        private Image _image;

        private ImageViewModel(Image image)
        {
            _image = image;
        }
        
        public double Width => _image.Width;

        public double Height => _image.Height;

        public static ImageViewModel Create(string path)
        {
            return new(Image.Load(path));
        }

        public void Dispose()
        {
            _image?.Dispose();
        }
    }
}
