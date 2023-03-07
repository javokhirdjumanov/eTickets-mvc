﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.mvc.Models;
public class Producer
{
    [Key]
    public int Id { get; set; }

    public string ProfilePictureUrl { get; set; }
    public string FullName { get; set; }
    public string Biography { get; set; }

    public List<Movie> Movies { get; set; }
}
