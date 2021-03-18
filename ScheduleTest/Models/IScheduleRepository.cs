using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleTest.Models
{
    public interface IScheduleRepository
    {
        //making a getter for the appointment object
        IQueryable<Appointment> Appointments { get; }
    }
}
