using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Dialogs;
using Avalonia.ReactiveUI;

namespace Paint
{
    class Program
    {
        public static void Main(string[] args) => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .UseManagedSystemDialogs()
                //.UseManagedSystemDialogs()
                .With(new Win32PlatformOptions()
                {
                    AllowEglInitialization = true
                })
                .LogToTrace()
                .UseReactiveUI();
    }
}
