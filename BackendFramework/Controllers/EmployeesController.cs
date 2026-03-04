using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnboardingAPI.Data;
using OnboardingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace OnboardingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public EmployeesController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Authorize(Roles = "HR, Admin")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        [HttpGet]
        [Authorize(Roles = "HR, Admin")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null) return NotFound();
            return employee;
        }

        [HttpPost]
        [Authorize(Roles = "HR")]
        public async Task<ActionResult<Employee>> CreateEmployee([FromBody] CreateEmployeeDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (!string.IsNullOrWhiteSpace(dto.PersonalEmail))
            {
                var exists = await _context.Employees.AnyAsync(e => e.PersonalEmail == dto.PersonalEmail);
                if (exists) return Conflict(new { message = "An employee with this email already exists." });
            }
            var employee = new Employee
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                PersonalEmail = dto.PersonalEmail,
                StartDate = dto.StartDate,
                Position = dto.Position
            };

            _context.Employees.Add(employee);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, new { message = "Database error while creating employee.", detail = ex.Message });
            }

            return CreatedAtAction(nameof(GetEmployee), new { id = employee.EmployeeId }, employee);
        }
    }

    public class  CreateEmployeeDto
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [EmailAddress]
        public string? PersonalEmail { get; set; }
        public DateTime StartDate { get; set; }
        public string? Position { get; set; }

    }
}
