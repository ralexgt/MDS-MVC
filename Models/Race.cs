using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcRace.Models;

public class Race
{
    public int Id { get; set; }

    [Display(Name = "Number"), StringLength(2, MinimumLength = 1), Required]
    public string? No { get; set; }

    [Display(Name = "Grand Prix"), StringLength(99, MinimumLength = 3), Required]
    public string? Name { get; set; }

    [Display(Name = "Circuit"), StringLength(99, MinimumLength = 3), Required]
    public string? Circuit { get; set; }

    [Display(Name = "Country"), StringLength(99, MinimumLength = 3), Required]
    public string? Country { get; set; }

    [Display(Name = "Starting Date"), DataType(DataType.Date),
     DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true), Required]
    public DateTime StartDate { get; set; }

    [Display(Name = "Starting Date"), DataType(DataType.Date),
     DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true), Required]
    public DateTime EndDate { get; set; }

    public string? Status { get; set; }

    [Display(Name = "Winner"), StringLength(99, MinimumLength = 3), Required]
    public string? Winner { get; set; }
}