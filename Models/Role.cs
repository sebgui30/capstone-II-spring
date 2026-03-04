using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnboardingAPI.Models
{
    // This class represents a job role or permission group used by the onboarding app.
    //This class is mapped to the "roles" table in the "onboarding" schema.
    [Table("roles", Schema = "onboarding")]
    public class Role
    {
        // Unique identfier for the role.
        [Key]
        [Column("role_id")]
        public int RoleId { get; set; }

        // The readable name of the role.
        [Required]
        [Column("role_name")]
        public string RoleName { get; set; } = string.Empty;
    }
}