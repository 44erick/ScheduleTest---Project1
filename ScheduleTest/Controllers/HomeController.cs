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

        public IActionResult Availability()
        {
            //return View(_repository.Appointments);
            return View();
        }

        //Sign Up Page FORM GET
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        //Sign Up Page FORM POST
        [HttpPost]
        public IActionResult SignUp(int appointmentId)
        {
            Appointment appointment = context.Appointments.Where(a => a.AppointmentId == appointmentId).FirstOrDefault();
            ViewBag.Appointment = appointment;
            return View("SignUp");
        }
        //Home Page 
        public IActionResult Index()
        {
            return View();
        }

        ////COMMENTED OUT UNTIL THE CORRECT FORMS AND OBJECTS ARE CREATED THAT WILL ALLOW ME TO PASS IN THE INFO I NEED FOR THE SIGN UP INFO
        ////Sign Up Page FORM POST
        //[HttpPost]
        //public IActionResult SignUp(SignUpInfo oSignUpInfo) //I NEED TO PUT IN THE CORRECT ROUTE FOR THE MODEL BEFORE THIS WILL WORK
        //{
        //    //don't submit the form unless everything has been inputted correctly.
        //    if (ModelState.IsValid)
        //    {
        //        //Add entry to  DB
        //        context.Tasks.Add(oSignUpInfo);
        //        //update DB
        //        context.SaveChanges();
        //        //send them back to the home page
        //        return View("Index");
        //    }
        //    //if incorrect, just send them the form page again
        //    return View();
        //}

        //View Appointments Page

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
