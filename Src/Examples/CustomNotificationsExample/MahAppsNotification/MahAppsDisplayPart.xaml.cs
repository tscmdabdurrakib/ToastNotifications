using ToastNotifications.Core;

namespace CustomNotificationsExample.MahAppsNotification
{
    /// <summary>
    /// Interaction logic for MahAppsDisplayPart.xaml
    /// </summary>
    public partial class MahAppsDisplayPart : NotificationDisplayPart
    {
        public MahAppsDisplayPart(MahAppsNotification notification)
        {
            InitializeComponent();
            Bind(notification);
        }
    }
}
