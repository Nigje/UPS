using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UPS.Framework.AspNet.Mvc
{
    /// <summary>
    /// It's inherited from .net core base controller that has minimum member and properties. 
    /// So in implementing WebApi, we prefer that.
    /// </summary>
    public class UPSControllerBase : ControllerBase
    {
        //**************************************************************************************************
        //Variables:

        /// <summary>
        /// Logger.
        /// </summary>
        protected readonly ILogger _logger;
        //**************************************************************************************************
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="logger"></param>
        protected UPSControllerBase(ILogger logger)
        {
            _logger = logger;
        }
        //**************************************************************************************************
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="logger"></param>
        public UPSControllerBase()
        {

        }
        //**************************************************************************************************
    }
}
