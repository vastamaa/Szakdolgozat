namespace BookStore.API.Models
{
    public class Language
    {
        public Guid LanguageId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        //Navigation
        public List<Book>? Books { get; set; }
    }
}
