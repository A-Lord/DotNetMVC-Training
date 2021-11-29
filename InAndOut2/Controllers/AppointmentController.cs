using Microsoft.AspNetCore.Mvc;
using System;

namespace InAndOut2.Controllers
{
    public class AppointmentController : Controller 
    {
        public IActionResult Index()  // returns the index from the appointment map coz we are in 
        { // the appointmentController file. http://localhost:1111/Appointment/index
            
            return View();
            
        }
        public IActionResult details(int id) //https://localhost:44384/appointment/details/1313 exemple 
        {     //https://localhost:1337/{controller}/{action}/{id}
            return Ok("you have entered id = " + id); 
        }

    }
}
