using RabbitMQ.Client;
using System;
using System.Text;

namespace Widget.Provisioner
{
    public class ProvisionerConsumer : QueueingBasicConsumer
    {
        public ProvisionerConsumer(IModel model) : base(model)
        {
        }

        public override void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, IBasicProperties properties, byte[] body)
        {
            Console.WriteLine("consumerTag: {0}", consumerTag);
            Console.WriteLine("deliveryTag: {0}", deliveryTag);
            Console.WriteLine("redelivered: {0}", redelivered);
            Console.WriteLine("exchange: {0}", exchange);
            Console.WriteLine("routingKey: {0}", routingKey);
            Console.WriteLine("body: {0}", Encoding.UTF8.GetString(body));
        }
    }
}
