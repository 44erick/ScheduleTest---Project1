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

                    //one day
                    new Appointment
                    {     
                        Time = "8:00am", 
                        Day = "Monday"
                    },
                    new Appointment
                    {

                        Time = "9:00am",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        Time = "10:00am",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        Time = "11:00am",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        Time = "12:00pm",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        Time = "1:00pm",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        Time = "2:00pm",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        Time = "3:00pm",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        Time = "4:00pm",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        Time = "5:00pm",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        Time = "6:00pm",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        Time = "7:00pm",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        Time = "8:00pm",
                        Day = "Monday"
                    },

                    //tuesday
                    new Appointment
                    {
                        Time = "8:00am",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {

                        Time = "9:00am",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        Time = "10:00am",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        Time = "11:00am",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        Time = "12:00pm",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        Time = "1:00pm",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        Time = "2:00pm",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        Time = "3:00pm",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        Time = "4:00pm",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        Time = "5:00pm",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        Time = "6:00pm",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        Time = "7:00pm",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        Time = "8:00pm",
                        Day = "Tuesday"
                    },

                    //wednesday
                    new Appointment
                    {
                        Time = "8:00am",
                        Day = "Wednesday"
                    },
                    new Appointment
                    {

                        Time = "9:00am",
                        Day = "Wednesday"
                    },
                    new Appointment
                    {
                        Time = "10:00am",
                        Day = "Wednesday"
                    },
                    new Appointment
                    {
                        Time = "11:00am",
                        Day = "Wednesday"
                    },
                    new Appointment
                    {
                        Time = "12:00pm",
                        Day = "Wednesday"
                    },
                    new Appointment
                    {
                        Time = "1:00pm",
                        Day = "Wednesday"
                    },
                    new Appointment
                    {
                        Time = "2:00pm",
                        Day = "Wednesday"
                    },
                    new Appointment
                    {
                        Time = "3:00pm",
                        Day = "Wednesday"
                    },
                    new Appointment
                    {
                        Time = "4:00pm",
                        Day = "Wednesday"
                    },
                    new Appointment
                    {
                        Time = "5:00pm",
                        Day = "Wednesday"
                    },
                    new Appointment
                    {
                        Time = "6:00pm",
                        Day = "Wednesday"
                    },
                    new Appointment
                    {
                        Time = "7:00pm",
                        Day = "Wednesday"
                    },
                    new Appointment
                    {
                        Time = "8:00pm",
                        Day = "Wednesday"
                    },

                    //Thursday
                    new Appointment
                    {
                        Time = "8:00am",
                        Day = "Thursday"
                    },
                    new Appointment
                    {

                        Time = "9:00am",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        Time = "10:00am",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        Time = "11:00am",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        Time = "12:00pm",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        Time = "1:00pm",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        Time = "2:00pm",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        Time = "3:00pm",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        Time = "4:00pm",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        Time = "5:00pm",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        Time = "6:00pm",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        Time = "7:00pm",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        Time = "8:00pm",
                        Day = "Thursday"
                    },

                    //Friday
                    new Appointment
                    {
                        Time = "8:00am",
                        Day = "Friday"
                    },
                    new Appointment
                    {

                        Time = "9:00am",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        Time = "10:00am",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        Time = "11:00am",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        Time = "12:00pm",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        Time = "1:00pm",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        Time = "2:00pm",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        Time = "3:00pm",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        Time = "4:00pm",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        Time = "5:00pm",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        Time = "6:00pm",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        Time = "7:00pm",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        Time = "8:00pm",
                        Day = "Friday"
                    },

                    //Saturday
                    new Appointment
                    {
                        Time = "8:00am",
                        Day = "Saturday"
                    },
                    new Appointment
                    {

                        Time = "9:00am",
                        Day = "Saturday"
                    },
                    new Appointment
                    {
                        Time = "10:00am",
                        Day = "Saturday"
                    },
                    new Appointment
                    {
                        Time = "11:00am",
                        Day = "Saturday"
                    },
                    new Appointment
                    {
                        Time = "12:00pm",
                        Day = "Saturday"
                    },
                    new Appointment
                    {
                        Time = "1:00pm",
                        Day = "Saturday"
                    },
                    new Appointment
                    {
                        Time = "2:00pm",
                        Day = "Saturday"
                    },
                    new Appointment
                    {
                        Time = "3:00pm",
                        Day = "Saturday"
                    },
                    new Appointment
                    {
                        Time = "4:00pm",
                        Day = "Saturday"
                    },
                    new Appointment
                    {
                        Time = "5:00pm",
                        Day = "Saturday"
                    },
                    new Appointment
                    {
                        Time = "6:00pm",
                        Day = "Saturday"
                    },
                    new Appointment
                    {
                        Time = "7:00pm",
                        Day = "Saturday"
                    },
                    new Appointment
                    {
                        Time = "8:00pm",
                        Day = "Saturday"
                    },

                    //Sunday
                    new Appointment
                    {
                        Time = "8:00am",
                        Day = "Sunday"
                    },
                    new Appointment
                    {

                        Time = "9:00am",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        Time = "10:00am",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        Time = "11:00am",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        Time = "12:00pm",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        Time = "1:00pm",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        Time = "2:00pm",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        Time = "3:00pm",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        Time = "4:00pm",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        Time = "5:00pm",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        Time = "6:00pm",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        Time = "7:00pm",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        Time = "8:00pm",
                        Day = "Sunday"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
