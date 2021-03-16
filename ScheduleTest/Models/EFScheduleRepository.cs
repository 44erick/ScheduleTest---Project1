using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleTest.Models
{
    public class EFScheduleRepository : IScheduleRepository
    {
        private ScheduleTestDbContext _context;

        //constructor
        public EFScheduleRepository (ScheduleTestDbContext context)
        {
            _context = context;
        }
        public IQueryable<Appointment> Appointments => _context.Appointments;
    }
}
