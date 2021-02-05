using Avalonia.Controls;
using Avalonia.Media;
using Paint.ViewModels;

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