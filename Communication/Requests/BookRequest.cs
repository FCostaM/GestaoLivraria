using GestaoLivraria.Communication.Enums;

namespace GestaoLivraria.Communication.Requests
{
    public class BookRequest
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; } = 0;
    }
}
