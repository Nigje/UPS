using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPS.WindowsForm.Models
{
    public class UPSExceptionModel
    {
        /// <summary>
        /// This property can be used to indicate that the current user has no privilege to perform this request.
        /// </summary>
        public bool __unauthorizedRequest { get; set; }
        /// <summary>
        /// It's used in the client to detect if this is a response wrapped by UPS framework.
        /// </summary>
        public bool __wrapped { get; set; } = true;

        /// <summary>
        /// If set, represents the traceId of the current request.
        /// For now, the traceId is exposed only in Development and Staging environment.
        /// </summary>
        public string __traceId { get; set; }

        /// <summary>
        /// Error details (Must and only set if <see cref="Success"/> is false).
        /// </summary>
        public ErrorInfo Error { get; set; }
    }
    /// <summary>
    /// Api error result details.
    /// </summary>
    public class ErrorInfo
    {
        /// <summary>
        /// Error code.
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Error details.
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// Source of the error. Generally it'll point to the service which the exception is originated from.
        /// </summary>
        public string Source { get; set; }
    }
}
