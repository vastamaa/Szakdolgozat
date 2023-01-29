using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace BookStore.API.Entities.Exceptions
{
    [ExcludeFromCodeCoverage]
    [Serializable]
    public class BadRequestException : Exception
    {
        protected BadRequestException(string message) : base(message) { }

        protected BadRequestException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext) { }
    }
}
