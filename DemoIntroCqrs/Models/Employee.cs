namespace DemoIntroCqrs.Models
{
    /// <summary>
    /// Represents an employee.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets the employee id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the employee name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the employee email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a value indicating if the client is active or not.
        /// </summary>
        public bool IsActive { get; set; }
    }
}