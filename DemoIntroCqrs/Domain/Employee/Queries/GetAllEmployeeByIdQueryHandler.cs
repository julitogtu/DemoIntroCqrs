using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace DemoIntroCqrs.Domain.Employee.Queries
{
    public class GetAllEmployeeByIdQueryHandler : IRequestHandler<GetAllEmployeeByIdQuery, EmployeeDto>
    {
        public async Task<EmployeeDto> Handle(GetAllEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return new EmployeeDto
            {
                Id = request.Id,
                Email = "test@test.com",
                Name = "test",
                IsActive = true
            };
        }
    }
}