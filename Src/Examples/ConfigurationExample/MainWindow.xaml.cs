using System.Windows;

namespace ConfigurationExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _vm = new MainViewModel();
        }

        private int _count = 0;
        private readonly MainViewModel _vm;

        private string CreateMessage()
        {
            return $"{_count++} {SampleTextInput.Text}";
        }

        private void Button_ShowInformationClick(object sender, RoutedEventArgs e)
        {
            _vm.ShowInformation(CreateMessage());
        }

        private void Button_ShowSuccessClick(object sender, RoutedEventArgs e)
        {
            _vm.ShowSuccess(CreateMessage());
        }

        private void Button_ShowWarningClick(object sender, RoutedEventArgs e)
        {
            _vm.ShowWarning(CreateMessage());
        }

        private void Button_ShowErrorClick(object sender, RoutedEventArgs e)
        {
            _vm.ShowError(CreateMessage());
        }

        private void Button_ShowCustomizedMessageClick(object sender, RoutedEventArgs e)
        {
            _vm.ShowCustomizedMessage(CreateMessage());
        }

        private void Button_ClearLastClick(object sender, RoutedEventArgs e)
        {
            _vm.ClearLast();
        }

        private void Button_ClearAllClick(object sender, RoutedEventArgs e)
        {
            _vm.ClearAll();
        }

        private void Button_ClearByTag(object sender, RoutedEventArgs e)
        {
            _vm.ClearByTag();
        }

        private void Button_ClearByMessage(object sender, RoutedEventArgs e)
        {
            _vm.ClearByMessage();
        }
    }
}
