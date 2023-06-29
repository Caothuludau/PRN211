using ASPMVC_App.Models;
using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.Mvc;

namespace ASPMVC_App.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult List(int id)
        {
            using (var context = new APContext())
            {
                List<Course> courses= null;
                if (id == 0)
                {
                    courses = context.Courses.ToList();
                }
                else
                {
                    courses = context.Courses.Where(x => x.SubjectId == id).ToList();
                }
                List<Subject> subjects = context.Subjects.ToList();
                ViewBag.subjects = subjects;
                return View(courses);
            }
        }

        public IActionResult Detail(int id)
        {
            using(var context = new APContext()) 
            {
                Course course = context.Courses.Where(x => x.CourseId == id).FirstOrDefault();
                ViewBag.instructor = context.Instructors.Where(x => x.InstructorId == course.InstructorId).FirstOrDefault();
                ViewData["subjectName"] = context.Subjects.Where(x => x.SubjectId == course.SubjectId).FirstOrDefault().SubjectName;
                return View(course);
            }
        }
    }
}
