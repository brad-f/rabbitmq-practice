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

            using(var connection = factory.CreateConnection())
            using(var model = connection.CreateModel())
            { 
                model.QueueDeclare("widget", true, false, false, null);
                model.BasicPublish(string.Empty, "widget", null, widget.GetBytes());
            }

            Console.WriteLine(widget.ToJson());
        }
    }
}
