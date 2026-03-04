using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnboardingAPI.Models
{
    // This class represents a user account used to sign into the onboarding application.
    // This class maps to the "users" table in the "onboarding schema.
    // This differs from "Employee" because "User" is an account for signing into the application and handling authentication and access.
    // Employee on the other hand is a personnel record in the form of internal info.
    [Table("users", Schema = "onboarding")]
    public class User
    {
        // Unique number that identifies this particular user.
        // This is a value used by the system and generally is not to be changed by users.
        [Key]
        [Column("user_id")]
        public int UserId { get; set; }

        // The user's full name for display in the app.
        // This is required when creating the user.
        [Required]
        [Column("full_name")]
        public string FullName { get; set; } = string.Empty;

        // The user's email address, used to sign in and recieve confirmation and notifs.
        // This is required when creating the user.
        [Required]
        [Column("email")]
        public string Email { get; set; } = string.Empty;

        // The actual role object associated with this user.
        [Required]
        [Column("role_id")]
        public int RoleId { get; set; }

        // An indicator of whether or not the user account is active.
        // Defaults to true, if false, the user can not sign in.
        public Role? Role { get; set; }
        [Column("is_active")]
        public bool IsActive { get; set; } = true;

        // Useful history information indicating when the user account was created.
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        // A secure version of the user's password, stored as a hash rather than plaintext.
        [Column("password_hash")]
        public string? PasswordHash { get; set; }
    }
}