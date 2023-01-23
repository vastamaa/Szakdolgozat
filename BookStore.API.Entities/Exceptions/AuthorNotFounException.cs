using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace BookStore.API.Entities.Exceptions
{
    [ExcludeFromCodeCoverage]
    [Serializable]
    public class AuthorNotFounException : NotFoundException
    {
        public AuthorNotFounException(Guid authorId) : base($"The author with id: {authorId} doesn't exist in the database.")
        {
        }

        protected AuthorNotFounException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {
        }
    }
}
