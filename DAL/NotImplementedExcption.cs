using System;
using System.Runtime.Serialization;

namespace DAL
{
    [Serializable]
    internal class NotImplementedExcption : Exception
    {
        public NotImplementedExcption()
        {
        }

        public NotImplementedExcption(string message) : base(message)
        {
        }

        public NotImplementedExcption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotImplementedExcption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}