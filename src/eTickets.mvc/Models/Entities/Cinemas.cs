using System.ComponentModel.DataAnnotations;

namespace eTickets.mvc.Models;
public class Cinemas
{
    [Key]
    public int Id { get; set; }
    public string CinemaLogo { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
