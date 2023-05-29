using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using F1Calendar.Data;
using System;
using System.Linq;

namespace MvcRace.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new F1CalendarContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<F1CalendarContext>>()))
        {
            // Look for any inputs that may already be in the database.
            if (context.Race.Any())
            {
                return;   // Database already seeded.
            }
            context.Race.AddRange(
                new Race
                {
                    No="1",
                    Name = "Gulf Air Bahrain GP",
                    Circuit = "Bahrain International Circuit",
                    Country = "Bahrain",
                    StartDate = DateTime.Parse("2023-03-03"),
                    EndDate = DateTime.Parse("2023-03-05"),
                    Status = "Ended",
                    Winner = "M. Verstappen - Red Bull Racing"
                },
                new Race
                {
                    No = "2",
                    Name = "STC Saudi Arabian GP",
                    Circuit = "Jeddah Street Circuit",
                    Country = "Saudi Arabia",
                    StartDate = DateTime.Parse("2023-03-17"),
                    EndDate = DateTime.Parse("2023-03-19"),
                    Status = "Ended",
                    Winner = "Sergio Perez - Red Bull Racing"
                },
                new Race
                {
                    No = "3",
                    Name = "Rolex Australian GP",
                    Circuit = "Melbourne Grand Prix Circuit",
                    Country = "Australia",
                    StartDate = DateTime.Parse("2023-03-31"),
                    EndDate = DateTime.Parse("2023-04-02"),
                    Status = "Ended",
                    Winner = "M. Verstappen - Red Bull Racing"
                },
                new Race
                {
                    No = "4",
                    Name = "Azerbaijan GP",
                    Circuit = "Baku City Circuit",
                    Country = "Azerbaijan",
                    StartDate = DateTime.Parse("2023-04-28"),
                    EndDate = DateTime.Parse("2023-04-30"),
                    Status = "Ended",
                    Winner = "S. Perez - Red Bull Racing"
                },
                new Race
                {
                    No = "5",
                    Name = "Crypto.com Miami GP",
                    Circuit = "Miami International Autodrome",
                    Country = "U.S.A.",
                    StartDate = DateTime.Parse("2023-05 -05"),
                    EndDate = DateTime.Parse("2023-05-07"),
                    Status = "Ended",
                    Winner = "M. Verstappen - Red Bull Racing"
                },
                new Race
                {
                    No = "6",
                    Name = "Qatar Airways Emilia Romagna GP",
                    Circuit = "Autodromo Enzo e Dino Ferrari",
                    Country = "Italy",
                    StartDate = DateTime.Parse("2023-05-19"),
                    EndDate = DateTime.Parse("2023-05-21"),
                    Status = "Canceled",
                    Winner = " - "
                },
                new Race
                {
                    No = "7",
                    Name = "Monaco GP",
                    Circuit = "Circuit de Monaco",
                    Country = "Monaco",
                    StartDate = DateTime.Parse("2023-05-26"),
                    EndDate = DateTime.Parse("2023-05-28"),
                    Status = "upcoming",
                    Winner = " - "
                },
                new Race
                {
                    No = "8",
                    Name = "AWS Spanish GP",
                    Circuit = "Circuit de Barcelona-Catalunya",
                    Country = "Spain",
                    StartDate = DateTime.Parse("2023-06-02"),
                    EndDate = DateTime.Parse("2023-06-04"),
                    Status = "upcoming",
                    Winner = " - "
                },
                new Race
                {
                    No = "9",
                    Name = "Pirelli Canada GP",
                    Circuit = "Circuit Gilles-Villeneuve",
                    Country = "Canada",
                    StartDate = DateTime.Parse("2023-06-16"),
                    EndDate = DateTime.Parse("2023-06-18"),
                    Status = "upcoming",
                    Winner = " - "
                },
                new Race
                {
                    No = "10",
                    Name = "Austrian GP",
                    Circuit = "Red Bull Ring",
                    Country = "Austria",
                    StartDate = DateTime.Parse("2023-06-30"),
                    EndDate = DateTime.Parse("2023-07-02"),
                    Status = "upcoming",
                    Winner = " - "
                },
                new Race
                {
                    No = "11",
                    Name = "Aramco British GP",
                    Circuit = "Silverstone Circuit",
                    Country = "U.K.",
                    StartDate = DateTime.Parse("2023-07-07"),
                    EndDate = DateTime.Parse("2023-07-09"),
                    Status = "upcoming",
                    Winner = " - "
                },
                new Race
                {
                    No = "12",
                    Name = "Qatar Airways Hungarian GP",
                    Circuit = "Hungaroring",
                    Country = "Hungary",
                    StartDate = DateTime.Parse("2023-07-21"),
                    EndDate = DateTime.Parse("2023-07-23"),
                    Status = "upcoming",
                    Winner = " - "
                },
                new Race
                {
                    No = "13",
                    Name = "MSC Cruises Belgian GP",
                    Circuit = "Circuit de Spa-Francorchamps",
                    Country = "Belgium",
                    StartDate = DateTime.Parse("2023-07-28"),
                    EndDate = DateTime.Parse("2023-07-30"),
                    Status = "upcoming",
                    Winner = " - "
                },
                new Race
                {
                    No = "14",
                    Name = "Heineken Dutch GP",
                    Circuit = "Circuit Park Zandvoort",
                    Country = "Netherlands",
                    StartDate = DateTime.Parse("2023-08-25"),
                    EndDate = DateTime.Parse("2023-08-27"),
                    Status = "upcoming",
                    Winner = " - "
                },
                new Race
                {
                    No = "15",
                    Name = "Pirelli Italian GP",
                    Circuit = "Autodromo Nazionale Monza",
                    Country = "Italy",
                    StartDate = DateTime.Parse("2023-09-01"),
                    EndDate = DateTime.Parse("2023-09-03"),
                    Status = "upcoming",
                    Winner = " - "
                },
                new Race
                {
                    No = "16",
                    Name = "Singapore Airlines Singapore GP",
                    Circuit = "Marina Bay Street Circuit",
                    Country = "Singapore",
                    StartDate = DateTime.Parse("2023-09-15"),
                    EndDate = DateTime.Parse("2023-09-17"),
                    Status = "upcoming",
                    Winner = " - "
                },
                new Race
                {
                    No = "17",
                    Name = "Lenovo Japanese GP",
                    Circuit = "Suzuka International Racing Course",
                    Country = "Japan",
                    StartDate = DateTime.Parse("2023-09-22"),
                    EndDate = DateTime.Parse("2023-09-24"),
                    Status = "upcoming",
                    Winner = " - "
                },
                new Race
                {
                    No = "18",
                    Name = "Qatar Airways Qatar GP",
                    Circuit = "Losail International Circuit",
                    Country = "Qatar",
                    StartDate = DateTime.Parse("2023-10-06"),
                    EndDate = DateTime.Parse("2023-10-08"),
                    Status = "upcoming",
                    Winner = " - "
                },
                new Race
                {
                    No = "19",
                    Name = "Lenovo United States GP",
                    Circuit = "Circuit of the Americas",
                    Country = "U.S.A.",
                    StartDate = DateTime.Parse("2023-10-20"),
                    EndDate = DateTime.Parse("2023-10-22"),
                    Status = "upcoming",
                    Winner = " - "
                },
                new Race
                {
                    No = "20",
                    Name = "Mexico City GP",
                    Circuit = "Autodromo Hermanos Rodriguez",
                    Country = "Mexico",
                    StartDate = DateTime.Parse("2023-10-27"),
                    EndDate = DateTime.Parse("2023-10-29"),
                    Status = "upcoming",
                    Winner = " - "
                },
                new Race
                {
                    No = "21",
                    Name = "Rolex São Paulo GP",
                    Circuit = "Autodromo Jose Carlos Pace",
                    Country = "Brazil",
                    StartDate = DateTime.Parse("2023-11-03"),
                    EndDate = DateTime.Parse("2023-11-05"),
                    Status = "upcoming",
                    Winner = " - "
                },
                new Race
                {
                    No = "22",
                    Name = "Heineken Las Vegas GP",
                    Circuit = "Las Vegas Street Circuit",
                    Country = "U.S.A.",
                    StartDate = DateTime.Parse("2023-11-17"),
                    EndDate = DateTime.Parse("2023-11-19"),
                    Status = "upcoming",
                    Winner = " - "
                },
                new Race
                {
                    No = "23",
                    Name = "Etihad Airways Abu Dhabi GP",
                    Circuit = "Yas Marina Circuit",
                    Country = "Abu Dhabi",
                    StartDate = DateTime.Parse("2023-11-24"),
                    EndDate = DateTime.Parse("2023-11-26"),
                    Status = "upcoming",
                    Winner = " - "
                }
            );
            context.SaveChanges();
        }
    }
}
