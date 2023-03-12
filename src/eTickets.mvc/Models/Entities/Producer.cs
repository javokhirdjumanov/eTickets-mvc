using System.ComponentModel.DataAnnotations;
namespace eTickets.mvc.Models;
public class Producer
{
    [Key]
    public int Id { get; set; }

    [Display(Name ="Profile Picture")]
    public string ProfilePictureUrl { get; set; }

    [Display(Name = "FullName")]
    public string FullName { get; set; }

    [Display(Name = "Biography")]
    public string Biography { get; set; }

    public List<Movie> Movies { get; set; }
}
