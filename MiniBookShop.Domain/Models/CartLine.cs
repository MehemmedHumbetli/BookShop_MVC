using MiniBookShop.Domain.Entities;

namespace MiniBookShop.Domain.Models
{
    public class CartLine
    {
        public Book Book { get; set; }
        public Course Course { get; set; }
        public int Quantity { get; set; }
    }
}
