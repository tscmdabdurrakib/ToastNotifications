using System.Windows;

namespace DotNetCoreUsageExample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // silly https://github.com/dotnet/wpf/issues/668
            var wnd = new Window
            {
                Height = 0,
                ShowInTaskbar = false,
                Width = 0,
                WindowStyle = WindowStyle.None
            };
            wnd.Show();
            wnd.Hide();

            var mainWindow = new MainWindow();
            mainWindow.Show();
            MainWindow = mainWindow;

            base.OnStartup(e);
        }
    }
}
