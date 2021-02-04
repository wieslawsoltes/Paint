using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using ReactiveUI;
using Image = SixLabors.ImageSharp.Image;

namespace Paint.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            FileNewCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            FileOpenCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                var dlg = new OpenFileDialog();

                var paths = await dlg.ShowAsync(GetWindow());
                if (paths is not null && paths.Length > 0)
                {
                    foreach (var path in paths)
                    {
                        using var image = Image.Load(path);

                        // TODO:
                    }
                }
            });

            FileSaveCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            FileSaveAsCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                
                var dlg = new SaveFileDialog();

                await dlg.ShowAsync(GetWindow());
            });

            FileExitCommand = ReactiveCommand.Create(Exit);

            EditUndoCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            EditRepeatCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            EditCutCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            EditCopyCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            EditPasteCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });
 
            EditClearSelectionCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            EditSelectAllCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            EditCopyToCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            EditPasteFromCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            ViewToolBoxCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            ViewColorBoxCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            ViewStatusBarCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            ViewTextToolbarCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            ViewZoomNormalSizeCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            ViewZoomLargeSizeCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            ViewZoomCustomCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            ViewZoomShowGridCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            ViewZoomShowThumbnailCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            ViewZoomViewBitmapCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

            ImageFlipRotateCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });
            
            ImageStretchSkewCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });
            
            ImageInvertColorsCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });
            
            ImageAttributesCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });
            
            ImageClearImageCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });
            
            ImageDrawOpaqueCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });
            
            ColorsEditColorsCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });
            
            HelpHelpTopicsCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });
            
            HelpAboutPaintCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                await Task.Yield();
            });

        }

        public ICommand FileNewCommand { get; }
        
        public ICommand FileOpenCommand { get; }
        
        public ICommand FileSaveCommand { get; }
        
        public ICommand FileSaveAsCommand { get; }
        
        public ICommand FileExitCommand { get; }

        public ICommand EditUndoCommand { get; }

        public ICommand EditRepeatCommand { get; }

        public ICommand EditCutCommand { get; }

        public ICommand EditCopyCommand { get; }

        public ICommand EditPasteCommand { get; }

        public ICommand EditClearSelectionCommand { get; }

        public ICommand EditSelectAllCommand { get; }

        public ICommand EditCopyToCommand { get; }

        public ICommand EditPasteFromCommand { get; }

        public ICommand ViewToolBoxCommand { get; }

        public ICommand ViewColorBoxCommand { get; }

        public ICommand ViewStatusBarCommand { get; }

        public ICommand ViewTextToolbarCommand { get; }

        public ICommand ViewZoomNormalSizeCommand { get; }

        public ICommand ViewZoomLargeSizeCommand { get; }

        public ICommand ViewZoomCustomCommand { get; }

        public ICommand ViewZoomShowGridCommand { get; }

        public ICommand ViewZoomShowThumbnailCommand { get; }

        public ICommand ViewZoomViewBitmapCommand { get; }

        public ICommand ImageFlipRotateCommand { get; }

        public ICommand ImageStretchSkewCommand { get; }

        public ICommand ImageInvertColorsCommand { get; }

        public ICommand ImageAttributesCommand { get; }

        public ICommand ImageClearImageCommand { get; }

        public ICommand ImageDrawOpaqueCommand { get; }

        public ICommand ColorsEditColorsCommand { get; }

        public ICommand HelpHelpTopicsCommand { get; }

        public ICommand HelpAboutPaintCommand { get; }

        private static Window? GetWindow()
        {
            if (Application.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime lifetime)
            {
                return lifetime.MainWindow;
            }

            return null;
        }

        private static void Exit()
        {
            if (Application.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime lifetime)
            {
                lifetime.Shutdown();
            }
        }
    }
}
