using System;
using System.Runtime.Serialization;

namespace ECommerce.Core.Exceptions
{
    public class ExceptionHandle : Exception
    {
        internal ExceptionHandle(string businessMessage)
            : base(businessMessage)
        {
        }

        internal ExceptionHandle(string message, Exception innerException)
            : base(message, innerException)
        {
        }
        internal ExceptionHandle(string message, params object[] args)
            : base(string.Format(message, args))
        {
        }
        protected ExceptionHandle(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}