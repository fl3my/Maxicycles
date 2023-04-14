﻿using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class Item
{
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    
    [Required]
    public string? Slug { get; set; }
    
    [Required]
    public string? Description { get; set; }
    
    [Required]
    public decimal Price { get; set; }

    // Many product to one subcategory.
    [Required]
    public int SubCategoryId { get; set; }
    public SubCategory? SubCategory { get; set; }
    
    // Many products to one image.
    public int ImageId { get; set; }
    public Image? Image { get; set; }
}