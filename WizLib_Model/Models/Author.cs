using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WizLib_Model.Models;

public class Author
{
    [Key]   // set PK and auto-increment
    // [DatabaseGenerated(DatabaseGeneratedOption.None)] // not auto-increment
    public int Author_Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Location { get; set; }
    [NotMapped]
    public string FullName { get => $"{FirstName} {LastName}"; }
    public List<Book> Books { get; set; } 
}
