using System;
using System.Collections.Generic;
using System.Text;
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
        }

        public ICommand FileNewCommand { get; }
        
        public ICommand FileOpenCommand { get; }
        
        public ICommand FileSaveCommand { get; }
        
        public ICommand FileSaveAsCommand { get; }
        
        public ICommand FileExitCommand { get; }

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
