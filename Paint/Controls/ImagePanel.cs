using System.IO;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Paint.ViewModels;
using SixLabors.ImageSharp;

namespace Paint.Controls
{
    public class ImagePanel : Panel
    {
        public override void Render(DrawingContext context)
        {
            base.Render(context);

            if (DataContext is ImageViewModel vm)
            {
                if (vm.Bitmap is not null)
                {
                    context.DrawImage(vm.Bitmap, vm.Bounds);
                }
            }
        }
    }
}