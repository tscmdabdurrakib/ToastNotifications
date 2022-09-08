using System.Windows;
using ToastNotifications.Core;

namespace ToastNotifications.Messages.Error
{
    /// <summary>
    /// Interaction logic for ErrorDisplayPart.xaml
    /// </summary>
    public partial class ErrorDisplayPart : NotificationDisplayPart
    {
        public ErrorDisplayPart(ErrorMessage error)
        {
            InitializeComponent();
            Bind(error);
        }

        private void OnClose(object sender, RoutedEventArgs e)
        {
            Notification.Close();
        }
    }
}
