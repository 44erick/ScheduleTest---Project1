using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleTest.Models
{
    public class ScheduleTestDbContext : DbContext
    {
        public ScheduleTestDbContext (DbContextOptions<ScheduleTestDbContext> options) : base (options)
        {

        }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
