using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleTest.Models
{
    public interface IScheduleRepository
    {
        IQueryable<Appointment> Appointments { get; }
    }
}
