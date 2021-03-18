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

        //set up repository
        private IScheduleRepository _repository;
        //set up context file
        private ScheduleTestDbContext context { get; set; }
        public HomeController(ILogger<HomeController> logger, IScheduleRepository repository, ScheduleTestDbContext con)
        {
            _logger = logger;
            _repository = repository;
            
            //allow access to context file
            context = con;
        }

        //Get request for Availability page
        [HttpGet]
        public IActionResult Availability()
        {
            return View(context.Appointments);
        }
        //Post Request for availability page
        [HttpPost]
        public IActionResult Availability(int appointmentId)
        {
            //pull in appointment based on appointmentId. Save it to appointment variable
            Appointment appointment = context.Appointments.Where(a => a.AppointmentId == appointmentId).FirstOrDefault();

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

        //Get Request for Booked Tours portion
        [HttpGet]
        public IActionResult BookedTours()
        {
            return View(context.SignUpInfos);
        }

        //Get request for Sign Up portion
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        //Post request for Sign Up portion
        [HttpPost]
        public IActionResult SignUp(SignUpInfo s, Appointment a)
        {
            //make sure inputs are correct before sending to DB
            if (ModelState.IsValid)
            {
                //save new signup to DB and then send to Index page
                context.SignUpInfos.Add(s);
                context.SaveChanges();
                Response.Redirect("Index");
                return View();
            }
            else
            {
                //send them the same page and display Validation
                return View();
            }
        }

        //Get Request for Index page
        public IActionResult Index()
        {
            return View();
        }

        //Get Request for Privacy page
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
