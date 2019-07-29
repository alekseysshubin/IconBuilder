using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using WpfTest.Properties;

namespace WpfTest
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            Left = Settings.Default.Left;
            Top = Settings.Default.Top;
        }

        private void MainWindow_OnClosing(object sender, CancelEventArgs e)
        {
            Settings.Default.Left = Left;
            Settings.Default.Top = Top;
            Settings.Default.Save();
        }

        private void MainWindow_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left) Left -= 1;
            else if (e.Key == Key.Right) Left += 1;
            else if (e.Key == Key.Up) Top -= 1;
            else if (e.Key == Key.Down) Top += 1;
        }
    }
}
