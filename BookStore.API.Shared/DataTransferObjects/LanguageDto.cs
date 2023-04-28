namespace BookStore.API.Shared.DataTransferObjects
{
    public record LanguageDto : BaseDto
    {
        public string Code { get; set; }
    }
}
