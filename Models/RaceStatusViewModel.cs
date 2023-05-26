using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcRace.Models;

public class RaceStatusViewModel
{
    public List<Race>? Races { get; set; }
    public SelectList? Statuses { get; set; }
    public string? RaceStatus { get; set; }
    public string? SearchString { get; set; }
}