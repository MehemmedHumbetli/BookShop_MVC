using MiniBookShop.Domain.Entities;

namespace MiniBookShop
{
    public class CourseViewModel
    {
        public Course Course { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Price { get; set; }
        public string Required_Skills { get; set; }
        public string ImagePath { get; set; }
    }
}