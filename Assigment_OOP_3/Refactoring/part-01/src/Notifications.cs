namespace Refactoring.src
{
    public interface INotification
    {
        void Send(string to, string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string to, string message) =>
            Console.WriteLine($"[email] {to}: {message}");
    }

    public class SmsNotification : INotification
    {
        public void Send(string to, string message) =>
            Console.WriteLine($"[sms] {to}: {message}");
    }

    public class WhatsUpNotification : INotification
    {
        public void Send(string to, string message) =>
            Console.WriteLine($"[whatsapp] {to}: {message}");
    }

    public class NotificationService
    {
        private readonly INotification _notification;

        public bool IsUrgent { get; set; }
        public DateTime? SendAt { get; set; }

        public NotificationService(INotification notification , bool isUrgent = false, DateTime? sendAt = null)
        {
            _notification = notification;
            IsUrgent = isUrgent;
            SendAt = sendAt;
        }
        public void send(string to, string message)
        {
            string finamlMessage = IsUrgent ? $"[URGENT] {message}" : message;

            if (SendAt.HasValue)
                Console.WriteLine($"[{_notification.GetType().Name.Replace("Notification", "")} scheduled {SendAt:g}] {to}: {finamlMessage}");
            else
                _notification.Send(to, finamlMessage);
        }
    }
}
