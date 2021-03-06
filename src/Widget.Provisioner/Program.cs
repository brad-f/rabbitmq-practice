﻿using RabbitMQ.Client;
using System;

namespace Widget.Provisioner
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.HostName = "192.168.50.4";

            using (var connection = factory.CreateConnection())
            using (var model = connection.CreateModel())
            {
                model.QueueDeclare("widget", true, false, false, null);
                var consumer = new ProvisionerConsumer(model);
                model.BasicConsume("widget", true, consumer);
                Console.ReadLine();
            }
        }
    }
}
