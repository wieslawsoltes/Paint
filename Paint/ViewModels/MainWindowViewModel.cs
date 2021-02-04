
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

        private Window? GetWindow()
        {
            if (Application.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime lifetime)
            {
                return lifetime.MainWindow;
            }

            return null;
        }

        private void Exit()
        {
            if (Application.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime lifetime)
            {
                lifetime.Shutdown();
            }
        }
    }
}
