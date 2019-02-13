using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoIntroCqrs.Domain.Employee;
using DemoIntroCqrs.Domain.Employee.Commands;
using DemoIntroCqrs.Domain.Employee.Queries;
using DemoIntroCqrs.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DemoIntroCqrs.Controllers
{
    /// <summary>
    /// Traditional employee controller.
    /// </summary>
    [ApiController]
    [Route("api/CqrsEmployees")]
    public class CqrsEmployeesController : ControllerBase
    {
        private readonly IMediator mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="CqrsEmployeesController"/> class.
        /// </summary>
        /// <param name="mediator"></param>
        public CqrsEmployeesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// Returns a list of employees.
        /// </summary>
        /// <returns>List of employees.</returns>
        [HttpGet]
        public async Task<ActionResult<List<EmployeeDto>>> GetAll()
        {
            var data = await mediator.Send(new GetAllEmployeesQuery());

            return data;
        }

        /// <summary>
        /// Returns an employee by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An employee.</returns>
        [HttpGet("{id:int}")]
        public async Task<ActionResult<EmployeeDto>> GetById(int id)
        {
            var data = await mediator.Send(new GetAllEmployeeByIdQuery { Id = id });

            return data;
        }

        /// <summary>
        /// Creates an employee.
        /// </summary>
        /// <param name="model">Employee data.</param>
        /// <returns>Http Code</returns>
        [HttpPost]
        public async Task<ActionResult> CreateEmployee(CreateEmployeeCommand command)
        {
            var result = await mediator.Send(command);

            return result.IsSuccess ? Ok() : StatusCode(500);
        }

        /// <summary>
        /// Changes the employee state to inactive.
        /// </summary>
        /// <param name="id">Employee id.</param>
        /// <returns>Http Code</returns>
        [HttpPost("inactivateemployee")]
        public async Task<ActionResult> InactivateEmployee(int id)
        {
            return Ok();
        }

        /// <summary>
        /// Changes the employee state to active.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Http Code</returns>
        [HttpPost("activateemployee")]
        public async Task<ActionResult> ActivateUser(int id)
        {
            return Ok();
        }

        /// <summary>
        /// Changes the employee email
        /// </summary>
        /// <param name="id">Employee id.</param>
        /// <param name="newEmail">New employee email.</param>
        /// <returns>Http Code</returns>
        [HttpPost("changeemployeeemail")]
        public async Task<ActionResult> ChangeEmployeeEmail(int id, string newEmail)
        {
            return Ok();
        }
    }
}