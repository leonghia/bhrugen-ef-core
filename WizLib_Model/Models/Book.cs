﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WizLib_Model.Models;

public class Book
{

    [Key]
    public int Book_Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    [MaxLength(15)]
    public string ISBN { get; set; }
    [Required]
    public double Price { get; set; }
    [NotMapped] // Not add this column into database
    public string PriceRange { get; set; }

    [ForeignKey("BookDetail")]
    public int BookDetail_Id { get; set; }
    public BookDetail BookDetail { get; set; }
    [ForeignKey("Publisher")]
    public int Publisher_Id { get; set; }
    public Publisher Publisher { get; set; }
    public List<Author> Authors { get; set; }
}
