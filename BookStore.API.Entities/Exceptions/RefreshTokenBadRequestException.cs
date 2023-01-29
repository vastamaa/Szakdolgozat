using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace BookStore.API.Entities.Exceptions
{
    [ExcludeFromCodeCoverage]
    [Serializable]
    public sealed class RefreshTokenBadRequestException : BadRequestException
    {
        public RefreshTokenBadRequestException() : base("Invalid client request. The tokenDto has some invalid values.") { }

        protected RefreshTokenBadRequestException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext) { }
    }
}
