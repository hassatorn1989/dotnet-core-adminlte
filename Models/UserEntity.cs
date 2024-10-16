using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PjAdminlte.Models;

[Table("User")]
public class UserEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; } = Guid.NewGuid();
    
    [Required(ErrorMessage = "Name is required")]
    [Column("name", TypeName = "varchar(100)")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Username is required")]
    [Column("username", TypeName = "varchar(100)")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [Column("password", TypeName = "varchar(100)")]
    public string Password { get; set; }

    // add createdAt and updatedAt
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
