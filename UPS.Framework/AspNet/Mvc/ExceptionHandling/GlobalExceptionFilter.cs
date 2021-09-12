using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using UPS.Framework.DI;
using UPS.Framework.Exceptions;
using UPS.Framework.Models;
using UPS.Framework.Options;
using UPS.Framework.Options.Models;

namespace UPS.Framework.AspNet.Mvc.ExceptionHandling
{
    /// <summary>
    /// It manipulates all exceptions that are thrown.
    /// </summary>
    public class GlobalExceptionFilter : IExceptionFilter, ITransientLifetime
    {
        //************************************************************************************************
        //Variables:
        /// <summary>
        /// Define logger to log exceptions.
        /// </summary>
        private readonly ILogger<GlobalExceptionFilter> _logger;
        private readonly IWebHostEnvironment _environment;
        //************************************************************************************************

        public GlobalExceptionFilter(ILogger<GlobalExceptionFilter> logger, IWebHostEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }
        //************************************************************************************************
        /// <summary>
        /// On exception event.
        /// </summary>
        /// <param name="context"></param>
        public void OnException(ExceptionContext context)
        {
            LogException(context.Exception);
            HandleResponse(context);
        }
        //************************************************************************************************
        /// <summary>
        /// Log exception.
        /// </summary>
        /// <param name="exception"></param>
        private void LogException(Exception exception)
        {
            var defaultSeverity = LogSeverityEnum.Error;
            string exceptionMessage = $"Processed an unhandled exception of type { exception.GetType().Name }:\r\nMessage: { exception.Message }";
            if (exception is UPSException businessException)
            {
                defaultSeverity = businessException.Severity;
                exceptionMessage = businessException.ToString();
            }
            switch (defaultSeverity)
            {
                case LogSeverityEnum.Debug:
                    _logger.LogDebug(exception, exceptionMessage);
                    break;
                case LogSeverityEnum.Info:
                    _logger.LogInformation(exception, exceptionMessage);
                    break;
                case LogSeverityEnum.Warn:
                    _logger.LogWarning(exception, exceptionMessage);
                    break;
                case LogSeverityEnum.Error:
                    _logger.LogError(exception, exceptionMessage);
                    break;
                case LogSeverityEnum.Critical:
                    _logger.LogCritical(exception, exceptionMessage);
                    break;
                default:
                    _logger.LogWarning(
                        "Invalid severity type is passed to LogException method, Please check the code and correct the issue");
                    _logger.LogError(exception, exceptionMessage);
                    break;
            }
        }
        //************************************************************************************************
        /// <summary>
        /// Handle resposen.
        /// </summary>
        /// <param name="context"></param>
        private void HandleResponse(ExceptionContext context)
        {
            //We use the error code that is set in BusinessException and 
            var errorCode = (context.Exception as UPSException)?.ErrorCode;

            context.HttpContext.Response.StatusCode = (int)GetHttpStatusCode(context.Exception);

            context.ExceptionHandled = true;

                context.Result = new ObjectResult(new ExceptionApiResult
                {
                    __unauthorizedRequest = false ,//Todo: Identity server,
                    __traceId = "",//Todo: Implement
                    Error = new ErrorInfo
                    {
                        Details = GetDetails(context.Exception),
                        ErrorCode = errorCode,
                        Message = context.Exception.Message,
                        Source = OptionService.GetOption<ServiceInfoOption>().FullName
                    }
                });


        }
        //************************************************************************************************
        private string GetDetails(Exception exception)
        {
            if (_environment.IsProduction())
                return null;
            string details = "";
            Exception tempException = exception;
            while (tempException != null)
            {
                details = tempException.GetType().Name + ": " + tempException.Message;
                if (tempException is UPSException)
                {
                    details += Environment.NewLine + ((UPSException)tempException).TechnicalMessage;
                }
                //Exception StackTrace
                if (!string.IsNullOrEmpty(tempException.StackTrace))
                {
                    details += Environment.NewLine + "Stack Trace: " + tempException.StackTrace + Environment.NewLine + Environment.NewLine;
                }
                tempException = tempException.InnerException;
            }
            return details;
        }
        //************************************************************************************************
        /// <summary>
        /// Get HttpStatusCode by using exception type.
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        private HttpStatusCode GetHttpStatusCode(Exception exception)
        {
            if (exception is UPSExceptionNotFound)
                return HttpStatusCode.NotFound;
            else if (exception is UPSExceptionInvalidParameter)
                return HttpStatusCode.UnprocessableEntity;
            else if (exception is UPSBusinessException)
                return HttpStatusCode.BadRequest; 
            else if (exception is UPSExceptionAuthenticationFailed)
                return HttpStatusCode.Forbidden;
            return HttpStatusCode.InternalServerError;
        }

        //************************************************************************************************
    }
}
