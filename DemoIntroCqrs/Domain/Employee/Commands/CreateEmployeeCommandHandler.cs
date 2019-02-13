using System.Threading;
using System.Threading.Tasks;
using DemoIntroCqrs.Support;
using MediatR;

namespace DemoIntroCqrs.Domain.Employee.Commands
{
    /// <summary>
    /// In charge to process the create employee command.
    /// </summary>
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, CommandResult>
    {
        private readonly IMediator mediator;

        public CreateEmployeeCommandHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<CommandResult> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            // Use dbcontext here to insert the employee.

            await mediator.Publish(new CreatedEmployeeEvent
            {
                Id = 1,
                Email = request.Email,
                Name = request.Name
            }, cancellationToken);

            return CommandResult.Success();
        }
    }
}