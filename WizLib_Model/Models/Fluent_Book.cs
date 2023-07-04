using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WizLib_Model.Models;

public class Fluent_Book
{

    
    public int Book_Id { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }
    public double Price { get; set; }
    public int BookDetail_Id { get; set; }
    public Fluent_BookDetail BookDetail { get; set; }
    public int Publisher_Id { get; set; }
    public Fluent_Publisher Publisher { get; set; }
    public List<Fluent_Author> Authors { get; set; }
}
