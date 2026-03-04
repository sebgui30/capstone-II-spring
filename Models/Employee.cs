using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnboardingAPI.Models
{
    // This class represents one employee record.
    // The application uses this to read and write employee data.
    // It is mapped to the database table named 'employees' in the 'onboarding' schema.
    [Table("employees", Schema = "onboarding")]
    public class Employee
    {
        // Primary key for employee record.
        // Uniquely identifies an individual employee in the system.
        [Key]
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        // Required field representing an employee's first name.
        [Required]
        [Column("first_name")]
        public string FirstName { get; set; } = string.Empty;

        // Required field representing an employee's last name.
        [Required]
        [Column("last_name")]
        public string LastName { get; set; } = string.Empty;

        // Optional field representing an employee's personal email address.
        [Column("personal_email")]
        public string? PersonalEmail { get; set; }

        // Required field representing an employee's start date with the company.
        //This field is stored as a date.
        [Required]
        [Column("start_date", TypeName = "date")]
        public DateTime? StartDate { get; set; }

        // Optional field representing an employee's department
        [Column("department")]
        public string? Department { get; set; }

        // Required field representing an employee's job title.
        [Required]
        [Column("job_title")]
        public string? JobTitle { get; set; }
    }
}