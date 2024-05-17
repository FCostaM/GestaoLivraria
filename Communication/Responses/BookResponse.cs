using GestaoLivraria.Communication.Enums;

namespace GestaoLivraria.Communication.Responses
{
    public class BookResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; } = 0;
    }
}
