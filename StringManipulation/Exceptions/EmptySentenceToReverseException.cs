using System.Runtime.Serialization;

namespace StringManipulation.Exceptions
{
    [Serializable]
    internal class NullSentenceToReverseException : Exception
    {
        public NullSentenceToReverseException()
        {
        }

        public NullSentenceToReverseException(string? message) : base(message)
        {
        }

        public NullSentenceToReverseException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NullSentenceToReverseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}