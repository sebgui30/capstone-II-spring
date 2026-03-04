using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnboardingAPI.Models
{
    [Table("employees", Schema = "onboarding")]
    public class Employee
    {
        [Key]
        [Column("employee_id")]
        public int EmployeeId { get; set; }
        [Required]
        [Column("first_name")]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [Column("last_name")]
        public string LastName { get; set; } = string.Empty;
        [Column("personal_email")]
        public string? PersonalEmail { get; set; }
        [Required]
        [Column("start_date", TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column("position")]
        public string? Position { get; set; }
    }
}