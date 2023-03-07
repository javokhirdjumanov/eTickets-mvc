using eTickets.mvc.Data;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.mvc.Models;
public class Movie
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string ImageUrl { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public MovieCategory MovieCategory { get; set; }

    // Actor -- Many To Many
    public List<Actor_Movie> Actor_Movies { get; set; }

    // Producer -- One To Many
    public int ProducerId { get; set; }
    [ForeignKey("ProducerId")]
    public Producer Producer { get; set; }

    // Cinema -- One To Many
    public int CinemaId { get; set; }
    [ForeignKey("CinemaId")]
    public Cinema Cinema { get; set; }
}
