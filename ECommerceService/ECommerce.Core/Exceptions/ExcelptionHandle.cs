using System;
namespace ECommerce.Core.Exceptions
{
    public class ExcelptionHandle : Exception
    {
        internal ExcelptionHandle(string businessMessage)
            : base(businessMessage)
        {
        }

        internal ExcelptionHandle(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}