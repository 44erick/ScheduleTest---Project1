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
        //making appointId our key
        //getters and setters for database
        [Key]
        public int AppointmentId { get; set; }
        public string Time { get; set; }

        public string Day { get; set; }
        //setting booked equal to false
        public bool Booked { get; set; } = false;
    }
}
