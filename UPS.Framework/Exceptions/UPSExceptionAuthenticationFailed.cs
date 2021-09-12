using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPS.Framework.Exceptions
{
    class UPSExceptionAuthenticationFailed : UPSException
    {
        public UPSExceptionAuthenticationFailed(string message = "Authentication Failed.", string technicalMessage = "", string errorCode = null) : base(message, technicalMessage, errorCode)
        {
        }
        public UPSExceptionAuthenticationFailed(string message, string technicalMessage, Exception innerException, string errorCode = null) : base(message, technicalMessage, innerException, errorCode)
        {
        }
    }
}
