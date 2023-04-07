﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class Image
{
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    
    [Required]
    [Display(Name = "Alternative Text")]
    public string? AltText { get; set; }
    public string? ImageName { get; set; }
    
    public DateTime UploadedAt { get; set; }
    
    // One image can have many products.
    public ICollection<Product> Products { get; } = new List<Product>();

}