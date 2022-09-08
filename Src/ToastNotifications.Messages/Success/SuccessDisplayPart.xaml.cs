using System.Windows;
using ToastNotifications.Core;

namespace ToastNotifications.Messages.Success
{
    /// <summary>
    /// Interaction logic for SuccessDisplayPart.xaml
    /// </summary>
    public partial class SuccessDisplayPart : NotificationDisplayPart
    {
        public SuccessDisplayPart(SuccessMessage success)
        {
            InitializeComponent();

            Bind(success);
        }

        private void OnClose(object sender, RoutedEventArgs e)
        {
            Notification.Close();
        }
    }
}
