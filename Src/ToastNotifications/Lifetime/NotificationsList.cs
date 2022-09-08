using System.Collections.Concurrent;
using System.Threading;
using ToastNotifications.Core;
using ToastNotifications.Utilities;

namespace ToastNotifications.Lifetime
{
    public class NotificationsList : ConcurrentDictionary<int, NotificationMetaData>
    {
        private int _id = 0;

        public NotificationMetaData Add(INotification notification)
        {
            var id = Interlocked.Increment(ref _id);
            var metaData = new NotificationMetaData(notification, id, DateTimeNow.Local.TimeOfDay);
            this[id] = metaData;
            return metaData;
        }
    }
}
