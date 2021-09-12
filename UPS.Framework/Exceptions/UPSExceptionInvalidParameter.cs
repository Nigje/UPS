﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UPS.Framework.Exceptions
{
    public class UPSExceptionInvalidParameter : UPSException
    {
        public UPSExceptionInvalidParameter(string message = "Invalid Parameter.", string technicalMessage = "", string errorCode = null) : base(message, technicalMessage, errorCode)
        {
        }
        public UPSExceptionInvalidParameter(string message, string technicalMessage, Exception innerException, string errorCode = null) : base(message, technicalMessage, innerException, errorCode)
        {
        }
    }
}
