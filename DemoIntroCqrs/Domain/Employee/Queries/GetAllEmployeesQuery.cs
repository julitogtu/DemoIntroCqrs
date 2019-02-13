using System.Collections.Generic;
using MediatR;

namespace DemoIntroCqrs.Domain.Employee.Queries
{
    public class GetAllEmployeesQuery : IRequest<List<EmployeeDto>>
    {
        
    }
}