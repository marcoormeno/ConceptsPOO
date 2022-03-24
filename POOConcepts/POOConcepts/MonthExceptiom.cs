using System.Runtime.Serialization;

namespace POOConcepts
{
    [Serializable]
    internal class MonthExceptiom : Exception
    {
        public MonthExceptiom()
        {
        }

        public MonthExceptiom(string? message) : base(message)
        {
        }

        public MonthExceptiom(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MonthExceptiom(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}