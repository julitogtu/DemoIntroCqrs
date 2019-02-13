using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace DemoIntroCqrs.Domain.Employee.Commands
{
    public class CreatedEmployeeEventHandler : INotificationHandler<CreatedEmployeeEvent>
    {
        private readonly ConnectionFactory connectionFactory;

        public CreatedEmployeeEventHandler()
        {
            connectionFactory = new ConnectionFactory
            {
                UserName = "",
                Password = "",
                VirtualHost = "",
                HostName = "",
                Uri = new Uri("amqp://..")
            };
        }

        public async Task Handle(CreatedEmployeeEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Employee: {JsonConvert.SerializeObject(notification)}");

            using (var connection = connectionFactory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(
                        queue: "newemployees",
                        durable: false,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null);

                    var jsonPayload = JsonConvert.SerializeObject(notification);
                    var body = Encoding.UTF8.GetBytes(jsonPayload);

                    channel.BasicPublish(
                        exchange: "",
                        routingKey: "newemployees",
                        basicProperties: null,
                        body: body);
                }
            }
        }
    }
}