using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace BookStore.API.Entities.Exceptions
{
    [ExcludeFromCodeCoverage]
    [Serializable]
    public class AuthorNotFoundException : NotFoundException
    {
        public AuthorNotFoundException(Guid authorId) : base($"The author with id: {authorId} doesn't exist in the database.") { }

        protected AuthorNotFoundException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext) { }
    }
}
