using System.ComponentModel.DataAnnotations;

namespace WizLib_Model.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}
