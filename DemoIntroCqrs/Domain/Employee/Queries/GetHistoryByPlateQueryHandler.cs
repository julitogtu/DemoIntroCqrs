using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace DemoIntroCqrs.Domain.Employee.Queries
{
    public class GetAllEmployeesQueryHandler : IRequestHandler<GetAllEmployeesQuery, List<EmployeeDto>>
    {
        public async Task<List<EmployeeDto>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            return new List<EmployeeDto>
            {
                new EmployeeDto
                {
                    Id = 1,
                    Email = "test@test.com",
                    Name = "test",
                    IsActive = true
                },
                new EmployeeDto
                {
                    Id = 2,
                    Email = "testII@test.com",
                    Name = "test II",
                    IsActive = true
                }
            };
        }
    }
}