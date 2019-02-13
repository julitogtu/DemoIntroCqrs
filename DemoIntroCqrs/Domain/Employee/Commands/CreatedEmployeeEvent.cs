using MediatR;

namespace DemoIntroCqrs.Domain.Employee.Commands
{
    public class CreatedEmployeeEvent : INotification
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}