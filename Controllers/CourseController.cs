using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Demo.ViewModels;
namespace Demo.Controllers
{
    public class CourseController : Controller
    {
        General general = new General();
        public IActionResult DoctorPage(int ID)
        {
            //Doctor_ID >> Course
            List<DoctorWithCourses> CourseId = general.DoctorCourses.Where(x => x.Doctor_ID == ID).ToList();
            ViewBag.Doctor = general.doctors.FirstOrDefault(x=>x.Id == ID);
            return View("DoctorPage", CourseId);
        }
        public IActionResult CoursePage(int ID)
        {
            //Course_id >> Students
            var Course_s_Student = general.Students.Join(
                general.attendneces,
                student => student.Id,
                attendence => attendence.Student_ID,
                (student, attendence) => new AttendenceWtithStudents
                {
                    Id = student.Id,
                    Name = student.Name,
                    Address = student.Address,
                    image = student.Image,
                    level = student.level,
                    Course_ID = attendence.Course_ID,
                    attend_count = attendence.Attendence_count,
                    attend_Max = attendence.Attendence_max
                }
            ).ToList();
            List<AttendenceWtithStudents> merged = Course_s_Student.Where(x=>x.Course_ID==ID).ToList();
            ViewBag.Course_name = general.Courses.FirstOrDefault(x => x.Id == ID).Name; ;
            return View("CoursePage", merged);
        }
        public IActionResult lectures(int id)
        {
            Lectures lectures = general.lectures.FirstOrDefault(x=> x.Course_ID == id);
            return View("lectures",lectures);
        }
    }
}
