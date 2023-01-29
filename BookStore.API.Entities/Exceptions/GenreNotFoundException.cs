using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace BookStore.API.Entities.Exceptions
{
    [ExcludeFromCodeCoverage]
    [Serializable]
    public class GenreNotFoundException : NotFoundException
    {
        public GenreNotFoundException(Guid genreId) : base($"The genre with id: {genreId} doesn't exist in the database.") { }

        protected GenreNotFoundException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext) { }
    }
}
