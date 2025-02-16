using MiniBookShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBookShop.Application.Abstract
{
    public interface ICourseService
    {
        public List<Course> GetAll();
        Book GetById(int id);
        void Add(Course course);
        void Update(Course course);
        void Delete(int courseId);
    }
}
