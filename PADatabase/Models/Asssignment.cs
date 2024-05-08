using PADatabase.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

public class Assignment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    public string Title { get; set; }

    public string Description { get; set; }

    public byte[] PdfData { get; set; } // Store PDF data as byte array

   

    
    public DateTime DueDate { get; set; }

    // Other properties as needed

    // Foreign key relationship with the Course
    public Guid CourseId { get; set; }
    public virtual Course Course { get; set; }
}