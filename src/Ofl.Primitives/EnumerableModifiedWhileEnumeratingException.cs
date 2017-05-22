using System;

namespace Ofl
{
    public sealed class EnumerableModifiedWhileEnumeratingException : Exception
    {
        private const string ExceptionMessage = "The enumerable was modified after the enumerator was created.";

        public EnumerableModifiedWhileEnumeratingException() : base(ExceptionMessage)
        { }

        public EnumerableModifiedWhileEnumeratingException(string message)
            : base(message)
        { }

        public EnumerableModifiedWhileEnumeratingException(Exception innerException)
            : base(ExceptionMessage, innerException)
        { }

        public EnumerableModifiedWhileEnumeratingException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
