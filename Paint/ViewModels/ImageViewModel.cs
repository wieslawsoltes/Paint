using ReactiveUI;

namespace Paint.ViewModels
{
    public class ImageViewModel : ViewModelBase
    {
        private double _width;
        private double _height;

        public double Width
        {
            get => _width;
            set => this.RaiseAndSetIfChanged(ref _width, value);
        }

        public double Height
        {
            get => _height;
            set => this.RaiseAndSetIfChanged(ref _height, value);
        }
    }
}
