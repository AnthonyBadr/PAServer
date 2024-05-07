﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ServerApp2.Models;

public class Course
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Indicates that the value is generated by the database
    public Guid Id { get; set; }

    public string Name { get; set; }
    public string? Description { get; set; }
    public double Fee { get; set; }
}