using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Model assigning the seed data to set up the different appointments on the page
namespace ScheduleTest.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            ScheduleTestDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<ScheduleTestDbContext>();
//making sure the db is connected and that it runs smoothly
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
                        AppointmentId = 1,
                        Time = "8:00am",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        AppointmentId = 2,
                        Time = "9:00am",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        AppointmentId = 3,
                        Time = "10:00am",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        AppointmentId = 4,
                        Time = "11:00am",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        AppointmentId = 5,
                        Time = "12:00pm",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        AppointmentId = 6,
                        Time = "1:00pm",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        AppointmentId = 7,
                        Time = "2:00pm",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        AppointmentId = 8,
                        Time = "3:00pm",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        AppointmentId = 9,
                        Time = "4:00pm",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        AppointmentId = 10,
                        Time = "5:00pm",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        AppointmentId = 11,
                        Time = "6:00pm",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        AppointmentId = 12,
                        Time = "7:00pm",
                        Day = "Monday"
                    },
                    new Appointment
                    {
                        AppointmentId = 13,
                        Time = "8:00pm",
                        Day = "Monday"
                    },

                    //tuesday
                    new Appointment
                    {
                        AppointmentId = 14,
                        Time = "8:00am",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        AppointmentId = 15,
                        Time = "9:00am",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        AppointmentId = 16,
                        Time = "10:00am",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        AppointmentId = 17,
                        Time = "11:00am",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        AppointmentId = 18,
                        Time = "12:00pm",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        AppointmentId = 19,
                        Time = "1:00pm",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        AppointmentId = 20,
                        Time = "2:00pm",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        AppointmentId = 21,
                        Time = "3:00pm",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        AppointmentId = 22,
                        Time = "4:00pm",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        AppointmentId = 23,
                        Time = "5:00pm",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        AppointmentId = 24,
                        Time = "6:00pm",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        AppointmentId = 25,
                        Time = "7:00pm",
                        Day = "Tuesday"
                    },
                    new Appointment
                    {
                        AppointmentId = 26,
                        Time = "8:00pm",
                        Day = "Tuesday"
                    },

                    //wednesday
                    new Appointment
                    {
                        AppointmentId = 27,
                        Time = "8:00am",
                        Day = "Wednesday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 28,
                        Time = "9:00am",
                        Day = "Wednesday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 29,
                        Time = "10:00am",
                        Day = "Wednesday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 30,
                        Time = "11:00am",
                        Day = "Wednesday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 31,
                        Time = "12:00pm",
                        Day = "Wednesday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 32,
                        Time = "1:00pm",
                        Day = "Wednesday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 33,
                        Time = "2:00pm",
                        Day = "Wednesday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 34,
                        Time = "3:00pm",
                        Day = "Wednesday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 35,
                        Time = "4:00pm",
                        Day = "Wednesday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 36,
                        Time = "5:00pm",
                        Day = "Wednesday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 37,
                        Time = "6:00pm",
                        Day = "Wednesday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 38,
                        Time = "7:00pm",
                        Day = "Wednesday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 39,
                        Time = "8:00pm",
                        Day = "Wednesday"
                    },

                    //Thursday
                    new Appointment
                    { 
                        AppointmentId= 40,
                        Time = "8:00am",
                        Day = "Thursday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 41,
                        Time = "9:00am",
                        Day = "Thursday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 42,
                        Time = "10:00am",
                        Day = "Thursday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 43,
                        Time = "11:00am",
                        Day = "Thursday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 44,
                        Time = "12:00pm",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        AppointmentId= 45,
                        Time = "1:00pm",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        AppointmentId= 46,
                        Time = "2:00pm",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        AppointmentId= 47,
                        Time = "3:00pm",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        AppointmentId= 48,
                        Time = "4:00pm",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        AppointmentId= 49,
                        Time = "5:00pm",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        AppointmentId= 50,
                        Time = "6:00pm",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        AppointmentId= 51,
                        Time = "7:00pm",
                        Day = "Thursday"
                    },
                    new Appointment
                    {
                        AppointmentId= 52,
                        Time = "8:00pm",
                        Day = "Thursday"
                    },

                    //Friday
                    new Appointment
                    { 
                        AppointmentId= 53,
                        Time = "8:00am",
                        Day = "Friday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 54,
                        Time = "9:00am",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        AppointmentId= 55,
                        Time = "10:00am",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        AppointmentId= 56,
                        Time = "11:00am",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        AppointmentId= 57,
                        Time = "12:00pm",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        AppointmentId= 58,
                        Time = "1:00pm",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        AppointmentId= 59,
                        Time = "2:00pm",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        AppointmentId= 60,
                        Time = "3:00pm",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        AppointmentId= 61,
                        Time = "4:00pm",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        AppointmentId= 62,
                        Time = "5:00pm",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        AppointmentId= 63,
                        Time = "6:00pm",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        AppointmentId= 64,
                        Time = "7:00pm",
                        Day = "Friday"
                    },
                    new Appointment
                    {
                        AppointmentId= 65,
                        Time = "8:00pm",
                        Day = "Friday"
                    },

                    //Saturday
                    new Appointment
                    {
                        AppointmentId= 66,
                        Time = "8:00am",
                        Day = "Saturday"
                    },
                    new Appointment
                    {
                        AppointmentId= 67,
                        Time = "9:00am",
                        Day = "Saturday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 68,
                        Time = "10:00am",
                        Day = "Saturday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 69,
                        Time = "11:00am",
                        Day = "Saturday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 70,
                        Time = "12:00pm",
                        Day = "Saturday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 71,
                        Time = "1:00pm",
                        Day = "Saturday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 72,
                        Time = "2:00pm",
                        Day = "Saturday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 73,
                        Time = "3:00pm",
                        Day = "Saturday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 74,
                        Time = "4:00pm",
                        Day = "Saturday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 75,
                        Time = "5:00pm",
                        Day = "Saturday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 76,
                        Time = "6:00pm",
                        Day = "Saturday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 77,
                        Time = "7:00pm",
                        Day = "Saturday"
                    },
                    new Appointment
                    { 
                        AppointmentId= 78,
                        Time = "8:00pm",
                        Day = "Saturday"
                    },

                    //Sunday
                    new Appointment
                    {
                        AppointmentId= 79,
                        Time = "8:00am",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        AppointmentId= 80,
                        Time = "9:00am",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        AppointmentId= 81,
                        Time = "10:00am",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        AppointmentId= 82,
                        Time = "11:00am",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        AppointmentId= 83,
                        Time = "12:00pm",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        AppointmentId= 84,
                        Time = "1:00pm",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        AppointmentId= 85,
                        Time = "2:00pm",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        AppointmentId= 86,
                        Time = "3:00pm",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        AppointmentId= 87,
                        Time = "4:00pm",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        AppointmentId= 88,
                        Time = "5:00pm",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        AppointmentId= 89,
                        Time = "6:00pm",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        AppointmentId= 90,
                        Time = "7:00pm",
                        Day = "Sunday"
                    },
                    new Appointment
                    {
                        AppointmentId= 91,
                        Time = "8:00pm",
                        Day = "Sunday"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
