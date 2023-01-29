using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace BookStore.API.Entities.Exceptions
{
    [ExcludeFromCodeCoverage]
    [Serializable]
    public class LanguageNotFoundException : NotFoundException
    {
        public LanguageNotFoundException(Guid languageId) : base($"The language with id: {languageId} doesn't exist in the database.") { }

        protected LanguageNotFoundException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext) { }
    }
}
