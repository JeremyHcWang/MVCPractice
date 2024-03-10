using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities;

public class Customer
{
    public int CustomerId { get; set; }
    [Column(TypeName="varchar(30)")]
    [Required (ErrorMessage ="Customer name is required")]
    public required string Name { get; set; }
    [Column(TypeName="varchar(60)")]
    public string? Address { get; set; }
    [Column(TypeName="varchar(15)")]
    public string? City { get; set; }
    [Column(TypeName="varchar(25)")]
    [Required (ErrorMessage ="Customer phone is required")]
    public required string Phone { get; set; }
}