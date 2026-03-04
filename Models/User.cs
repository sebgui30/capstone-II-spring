using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnboardingAPI.Models
{
    [Table("users", Schema = "onboarding")]
    public class User
    {
        [Key]
        [Column("user_id")]
        public int UserId { get; set; }
        [Required]
        [Column("full_name")]
        public string FullName { get; set; } = string.Empty;
        [Required]
        [Column("email")]
        public string Email { get; set; } = string.Empty;
        [Required]
        [Column("role_id")]
        public int RoleId { get; set; }
        public Role? Role { get; set; }
        [Column("is_active")]
        public bool IsActive { get; set; } = true;
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("password_hash")]
        public string? PasswordHash { get; set; }
    }
}