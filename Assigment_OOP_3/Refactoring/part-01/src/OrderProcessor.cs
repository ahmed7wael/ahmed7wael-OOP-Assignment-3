namespace Refactoring.src
{
    public interface IOrderRepository
    {
        public void Save(int orderId, DateTime processedAt);
    }

    public class SqlOrderRepository : IOrderRepository
    {
        public void Save(int orderId, DateTime processedAt) =>
            Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
    }

    public interface IEmailSender
    {
        public void Send(string to, string body);
    }

    public class SmtpEmailSender : IEmailSender
    {
        public void Send(string to, string body) =>
            Console.WriteLine($"[SMTP] to={to} body={body}");
    }
    public class OrderProcessor
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IEmailSender _emailSender;

        public OrderProcessor(IOrderRepository orderRepository, IEmailSender emailSender)
        {
            _orderRepository = orderRepository;
            _emailSender = emailSender;
        }
        public void Process(int orderId, string customerEmail)
        {
            _orderRepository.Save(orderId, DateTime.Now);
            _emailSender.Send(customerEmail, $"Order {orderId} confirmed at {DateTime.Now}");
        }

    }
}
