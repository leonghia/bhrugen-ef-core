using System.ComponentModel.DataAnnotations.Schema;

namespace WizLib_Model.Models;

[Table("tb_Genres")]
public class Genre
{
    public int GenreId { get; set; }
    [Column("Name")]
    public string GenreName { get; set; }
    // public int DisplayOrder { get; set; }
}
