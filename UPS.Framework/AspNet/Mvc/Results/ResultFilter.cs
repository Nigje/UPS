using Microsoft.AspNetCore.Mvc.Filters;
using UPS.Framework.DI;

namespace UPS.Framework.AspNet.Mvc.Results
{
    public class ResultFilter : IResultFilter, ITransientLifetime
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {

        }

        public void OnResultExecuting(ResultExecutingContext context)
        {

        }
    }
}
