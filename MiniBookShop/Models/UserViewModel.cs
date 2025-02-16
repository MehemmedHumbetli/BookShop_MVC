using MiniBookShop.Domain.Entities;

namespace MiniBookShop
{
    public class UserViewModel
    {
        public User User { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gmail { get; set; }
        public string ProfilePicturePath { get; set; }
    }
}