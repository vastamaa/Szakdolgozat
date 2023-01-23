using System.Diagnostics.CodeAnalysis;

namespace BookStore.API.Shared.DataTransferObjects
{
    [ExcludeFromCodeCoverage]
    public abstract record BaseDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}
