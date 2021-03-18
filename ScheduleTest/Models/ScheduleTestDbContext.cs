using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//setup context file as good practice when creating database. 

namespace ScheduleTest.Models
{
    public class ScheduleTestDbContext : DbContext
    {
        public ScheduleTestDbContext (DbContextOptions<ScheduleTestDbContext> options) : base (options)
        {

        }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<SignUpInfo> SignUpInfos { get; set; }
    }
}
