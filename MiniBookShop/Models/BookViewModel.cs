using MiniBookShop.Domain.Entities;

namespace MiniBookShop
{
    public class BookViewModel
    {
        public Book Book { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Pages { get; set; }
        public int ReadCount { get; set; }
        public string Decription { get; set; }
        public string ImagePath { get; set; }
        public int Price { get; set; }
    }
}