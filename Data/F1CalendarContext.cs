using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcRace.Models;

namespace F1Calendar.Data
{
    public class F1CalendarContext : DbContext
    {
        public F1CalendarContext (DbContextOptions<F1CalendarContext> options)
            : base(options)
        {
        }

        public DbSet<MvcRace.Models.Race> Race { get; set; } = default!;
    }
}
