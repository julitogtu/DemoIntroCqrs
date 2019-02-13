using MediatR;

namespace DemoIntroCqrs.Domain.Employee.Queries
{
    public class GetAllEmployeeByIdQuery : IRequest<EmployeeDto>
    {
        public int Id { get; set; }
    }
}