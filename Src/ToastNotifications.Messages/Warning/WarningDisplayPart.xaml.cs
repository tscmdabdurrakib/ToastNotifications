using System.Windows;
using ToastNotifications.Core;

namespace ToastNotifications.Messages.Warning
{
    /// <summary>
    /// Interaction logic for WarningDisplayPart.xaml
    /// </summary>
    public partial class WarningDisplayPart : NotificationDisplayPart
    {
        public WarningDisplayPart(WarningMessage warning)
        {
            InitializeComponent();

            Bind(warning);
        }

        private void OnClose(object sender, RoutedEventArgs e)
        {
            Notification.Close();
        }
    }
}
