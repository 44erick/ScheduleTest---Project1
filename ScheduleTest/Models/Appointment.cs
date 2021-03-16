using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleTest.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public string Time { get; set; }
    }
}
