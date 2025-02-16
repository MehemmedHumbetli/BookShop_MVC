using MiniBookShop.Application.Abstract;
using MiniBookShop.DataAccess.Abstract;
using MiniBookShop.DataAccess.Implementation;
using MiniBookShop.Domain.Entities;

namespace MiniBookShop.Application.Concrete
{
    public class CourseService(ICourseDal courseDal) : ICourseService
    {
        private readonly ICourseDal _courseDal = courseDal;

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(int courseId)
        {
            var course = _courseDal.Get(p => p.Id == courseId);
            _courseDal.Delete(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetList();
        }

        public Course GetById(int id)
        {
            return _courseDal.Get(p => p.Id == id);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
