using System;
using System.Windows;
using ToastNotifications.Core;

namespace BasicUsageExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _vm = new ToastViewModel();

            Unloaded += OnUnload;
        }

        private int _count = 0;
        private readonly ToastViewModel _vm;

        private void OnUnload(object sender, RoutedEventArgs e)
        {
            _vm.OnUnloaded();
        }

        private void Button_ShowInformationClick(object sender, RoutedEventArgs e)
        {
            ShowMessage(_vm.ShowInformation, "Information");
        }

        private void Button_ShowSuccessClick(object sender, RoutedEventArgs e)
        {
            ShowMessage(_vm.ShowSuccess, "Success");
        }

        private void Button_ShowWarningClick(object sender, RoutedEventArgs e)
        {
            ShowMessage(_vm.ShowWarning, "Warning");
        }

        private void Button_ShowErrorClick(object sender, RoutedEventArgs e)
        {
            ShowMessage(_vm.ShowError, "Error");
        }

        string _lastMessage;
        void ShowMessage(Action<string, MessageOptions> action, string name)
        {
            MessageOptions opts = new MessageOptions
            {
                CloseClickAction = CloseAction,
                Tag = $"[This is Tag Value ({++_count})]",
                FreezeOnMouseEnter = cbFreezeOnMouseEnter.IsChecked.GetValueOrDefault(),
                UnfreezeOnMouseLeave = cbUnfreezeOnMouseLeave.IsChecked.GetValueOrDefault(),
                ShowCloseButton = cbShowCloseButton.IsChecked.GetValueOrDefault()
            };
            _lastMessage = $"{_count} {name}";
            action(_lastMessage, opts);
            bClearLast.IsEnabled = true;
        }

        private void CloseAction(NotificationBase obj)
        {
            var opts = obj.DisplayPart.Notification.Options;
            _vm.ShowInformation($"Notification close clicked, Tag: {opts.Tag}");
        }


        private void Button_ClearClick(object sender, RoutedEventArgs e)
        {
            _vm.ClearAll();
        }

        private void Button_ClearLastClick(object sender, RoutedEventArgs e)
        {
            _vm.ClearMessages(_lastMessage);
            bClearLast.IsEnabled = false;
        }

        private void Button_SameContentClick(object sender, RoutedEventArgs e)
        {
            const string sameContent = "Same Content - not duplicated";
            _vm.ClearMessages(sameContent);
            MessageOptions opts = new MessageOptions
            {
                CloseClickAction = CloseAction,
                Tag = "[This is Tag Value]",
                FreezeOnMouseEnter = cbFreezeOnMouseEnter.IsChecked.GetValueOrDefault(),
                ShowCloseButton = cbShowCloseButton.IsChecked.GetValueOrDefault()
            };
            _vm.ShowSuccess(sameContent, opts);
            _lastMessage = sameContent;
            bClearLast.IsEnabled = true;
        }
    }
}
