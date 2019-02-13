using System.Collections.Generic;
using System.Threading.Tasks;
using DemoIntroCqrs.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoIntroCqrs.Controllers
{
    /// <summary>
    /// Traditional employee controller.
    /// </summary>
    [ApiController]
    [Route("api/TraditionalEmployees")]
    public class TraditionalEmployeesController : ControllerBase
    {
        /// <summary>
        /// Returns a list of employees.
        /// </summary>
        /// <returns>List of employees.</returns>
        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetAll()
        {
            return new List<Employee>();
        }

        /// <summary>
        /// Returns an employee by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An employee.</returns>
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Employee>> GetById(int id)
        {
            return new Employee();
        }

        /// <summary>
        /// Creates an employee.
        /// </summary>
        /// <param name="model">Employee data.</param>
        /// <returns>Http Code</returns>
        [HttpPost]
        public async Task<ActionResult> CreateEmployee(Employee model)
        {
            return Ok();
        }

        /// <summary>
        /// Updates an employee.
        /// </summary>
        /// <param name="id">Employee id.</param>
        /// <param name="model">Employee data.</param>
        /// <returns>Http Code.</returns>
        [HttpPut]
        public async Task<ActionResult> UpdateEmployee(int id, Employee model)
        {
            return Ok();
        }
    }
}