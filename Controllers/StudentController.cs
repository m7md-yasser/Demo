using Demo.Models;
using Demo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Reflection.Emit;
using System.Xml.Linq;


namespace Demo.Controllers
{
    public class StudentController : Controller
    {
         General general = new General();
        public IActionResult StudentPage(int id)
        {
            //Student_ID >> Courses
            var Student_Courses = general.Courses.Join(
               general.attendneces,
               Course => Course.Id,
               attendence => attendence.Course_ID,
               (Course, attendence) => new AttendenceWithCourses
               {
                   Name = Course.Name,
                   Image = Course.Image,
                   doc_Name = Course.doc_Name,
                  Student_ID = attendence.Student_ID,
                  Attendence_count = attendence.Attendence_count,
                  Attendence_max = attendence.Attendence_max ,
                  Course_id = Course.Id,
                  Doc_id = Course.Doctor_ID,
               }
           ).ToList();
            List<AttendenceWithCourses> att = Student_Courses.Where(x=>x.Student_ID==id).ToList();
            Student student = general.Students.FirstOrDefault(x=>x.Id==id);
            ViewBag.Student = student;
            return View("StudentPage",att);
        }
        public IActionResult AllStudents()
        {
            List<Student> students = general.Students.ToList();
            
            return View("AllStudents", students);
        }
    }
}
