using Microsoft.AspNetCore.Mvc;
using MiniBookShop.Application.Abstract;
using MiniBookShop.Domain.Entities;

namespace MiniBookShop.Controllers
{
    public class CourseController(ICourseService courseService) : Controller
    {
        private readonly ICourseService _courseService = courseService;

        public IActionResult Index()
        {
            var courses = _courseService.GetAll();
            return View(courses);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new CourseViewModel();
            model.Course = new Course();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(CourseViewModel model)
        {
            _courseService.Add(model.Course);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete()
        {
            var model = new CourseViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _courseService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var course = _courseService.GetById(id);
            if (course == null)
            {
                return NotFound();
            }

            var model = new CourseViewModel
            {
                Course = course
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(CourseViewModel model)
        {
            var courseInDb = _courseService.GetById(model.Course.Id);
            if (courseInDb == null)
            {
                return NotFound();
            }

            courseInDb.Name = model.Course.Name;
            courseInDb.Duration = model.Course.Duration;
            courseInDb.Price = model.Course.Price;
            courseInDb.Required_Skills = model.Course.Required_Skills;

            _courseService.Update(courseInDb);
            return RedirectToAction("Index");
        }
    }
}
