using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnboardingAPI.Models
{
    [Table("roles", Schema = "onboarding")]
    public class Role
    {
        [Key]
        [Column("role_id")]
        public int RoleId { get; set; }

        [Required]
        [Column("role_name")]
        public string RoleName { get; set; } = string.Empty;
    }
}