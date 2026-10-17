//using Refactoring.src;

//namespace Refactoring
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var shipping = new ShippingCostCalculator(new AramexShippingCostCalculator());
//            Console.WriteLine($"Aramex 2kg → {shipping.Calculate("Aramex", 2)}");
            
//            shipping = new ShippingCostCalculator(new FedExShippingCostCalculator());
//            Console.WriteLine($"FedEx 2kg  → {shipping.Calculate("FedEx", 2)}");

//            var shipping2 = new ShippingCostCalculator(new UPSShippingCostCalculator());
//            Console.WriteLine($"UPS 2kg → {shipping2.Calculate("UPS", 2)}");
//            Console.WriteLine();

//            var processor = new OrderProcessor(new SqlOrderRepository(), new SmtpEmailSender());
//            processor.Process(1001, "customer@example.com");
//            Console.WriteLine();

//            var emailNotification = new NotificationService(new EmailNotification(), isUrgent: true, sendAt: DateTime.Today.AddHours(18));
//          emailNotification.send("customer@example.com", "Your order ships tomorrow");

//          var smsNotification = new NotificationService(new SmsNotification() , isUrgent: true);
//            smsNotification.send("+201000000000", "OTP 4821");

//            var whatsUpNotification = new NotificationService(new WhatsUpNotification(), isUrgent: true);
//            whatsUpNotification.send("+201000000000", "Your order is on the way");

//        }
//    }
//}
