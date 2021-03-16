using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleTest.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            ScheduleTestDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<ScheduleTestDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Appointments.Any())
            {
                context.Appointments.AddRange(
                    new Appointment
                    {     
                        Time = "8:00am"
                    },
                    new Appointment
                    {

                        Time = "9:00am"
                    },
                    new Appointment
                    {
                        Time = "10:00am"
                    },
                    new Appointment
                    {
                        Time = "11:00am"
                    },
                    new Appointment
                    {
                        Time = "12:00pm"
                    },
                    new Appointment
                    {
                        Time = "1:00pm"
                    },
                    new Appointment
                    {
                        Time = "2:00pm"
                    },
                    new Appointment
                    {
                        Time = "3:00pm"
                    },
                    new Appointment
                    {
                        Time = "4:00pm"
                    },
                    new Appointment
                    {
                        Time = "5:00pm"
                    },
                    new Appointment
                    {
                        Time = "6:00pm"
                    },
                    new Appointment
                    {
                        Time = "7:00pm"
                    },
                    new Appointment
                    {
                        Time = "8:00pm"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
