namespace BookStore.API.Models
{
    public class Publisher
    {
        public Guid PublisherId { get; set; }
        public string? Name { get; set; }

        //Navigation
        public List<Book>? Books { get; set; }
    }
}
