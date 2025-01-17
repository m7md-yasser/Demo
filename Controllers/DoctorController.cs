using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace Demo.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult AllDoctor()
        {
            General studentbl = new General();
            List <Doctor> doctors = studentbl.doctors.ToList();
            return View("AllDoctor",doctors);
        }
    }
}
