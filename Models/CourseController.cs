using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyIF.Models;

public class Course
{
    [Required]
    public int Id { get; set; }
    [Required]  
    [Column(TypeName ="varchar(255)")]
    public string Name { get; set; }
    [Required]
    [Column(TypeName ="text")]
    public string Description { get; set; }
    [Required]
    public int Workload { get; set; }
    [Required]
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    [Required ]
    [Column(TypeName ="decimal(12,2)")]
    public decimal Amount { get; set; }
}
