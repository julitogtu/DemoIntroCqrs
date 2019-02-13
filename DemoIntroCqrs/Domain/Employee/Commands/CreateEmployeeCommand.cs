using DemoIntroCqrs.Support;
using MediatR;

namespace DemoIntroCqrs.Domain.Employee.Commands
{
    /// <summary>
    /// Create employee command.
    /// </summary>
    public class CreateEmployeeCommand : IRequest<CommandResult>
    {
        /// <summary>
        /// Gets or sets the employee name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the employee email.
        /// </summary>
        public string Email { get; set; }
    }
}