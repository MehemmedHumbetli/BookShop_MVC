using MiniBookShop.Domain.Abstraction;

namespace MiniBookShop.Domain.Entities
{
    public class Course : IEntity
    {  
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Price { get; set; }
        public string Required_Skills { get; set; }
        public string ImagePath { get; set; }
    }
}
