using FluentValidation;

namespace DemoIntroCqrs.Domain.Employee.Commands
{
    /// <summary>
    /// Validates the create employee command.
    /// </summary>
    public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmployeeCommandValidator"/> class.
        /// </summary>
        public CreateEmployeeCommandValidator()
        {
            RuleFor(c => c.Email)
                .EmailAddress()
                .WithMessage("The email is invalid.");

            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage("The name is invalid.")
                .NotNull()
                .WithMessage("The name is invalid.");
        }
    }
}