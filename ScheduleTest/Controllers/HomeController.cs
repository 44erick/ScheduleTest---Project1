using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScheduleTest.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IScheduleRepository _repository;
        private ScheduleTestDbContext context { get; set; }
        public HomeController(ILogger<HomeController> logger, IScheduleRepository repository, ScheduleTestDbContext con)
        {
            _logger = logger;
            _repository = repository;
            context = con;
        }
        [HttpGet]
        public IActionResult Availability()
        {
            return View(context.Appointments);
        }
        [HttpPost]
        public IActionResult Availability(int appointmentId)
        {
            Appointment appointment = context.Appointments.Where(a => a.AppointmentId == appointmentId).FirstOrDefault();
            //ViewBag.Appointment = new List<Appointment> appointment;

            //store the view bag object attributes that I need as temp data so they will persist between pages
            ViewBag.Appointment = appointment;
            TempData["ApptDay"] = ViewBag.Appointment.Day;
            TempData["ApptTime"] = ViewBag.Appointment.Time;

            //update appointment and set booked to true so it doesn't keep showing up
            appointment.Booked = true;
            context.Appointments.Update(appointment);
            context.SaveChanges();

            //return SignUp View
            return View("SignUp");
        }
        [HttpGet]
        public IActionResult BookedTours()
        {
            return View(context.SignUpInfos);
        }
        //Sign Up Page FORM GET
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpInfo s, Appointment a)
        {
            //Appointment appointment = context.Appointments.Where(a => a.AppointmentId == appointmentId).FirstOrDefault();
            //ViewBag.Appointment = appointment;
            //That required information is entered and validation model works
            if (ModelState.IsValid)
            {
                context.SignUpInfos.Add(s);
                context.SaveChanges();
                Response.Redirect("Index");
                return View();
            }
            else
            {
                return View();
            }
        }
        //Home Page 
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
