using RabbitMQ.Client;
using System;

namespace Widget.Api.Model
{
    public class WidgetService : IWidgetService
    {
        public void Add(Widget widget)
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.HostName = "192.168.50.4";

            var connection = factory.CreateConnection();
            var model = connection.CreateModel();

            var response = model.QueueDeclare("widget", true, false, false, null);

            Console.WriteLine("Widget");
        }
    }
}
