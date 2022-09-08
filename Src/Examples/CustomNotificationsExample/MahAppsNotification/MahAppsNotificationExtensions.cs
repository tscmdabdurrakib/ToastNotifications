using ToastNotifications;
using ToastNotifications.Core;

namespace CustomNotificationsExample.MahAppsNotification
{
    public static class MahAppsNotificationExtensions
    {
        public static void ShowMahAppsNotification(this Notifier notifier, 
            string title, 
            string message,
            MessageOptions messageOptions = null)
        {
            notifier.Notify(() => new MahAppsNotification(title, message, messageOptions));
        }
    }
}
