using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using UPS.Framework.Exceptions;
using UPS.Framework.Models;
using UPS.Framework.Options;
using UPS.Framework.Options.Models;

namespace UPS.Framework.AspNet
{
    /// <summary>
    /// Application builder extentions.
    /// </summary>
    public static class ApplicationBuilderExtentions
    {
        //*********************************************************************************************************
        //Variables:
        //*********************************************************************************************************
        /// <summary>
        /// Init app.
        /// </summary>
        /// <param name="app"></param>
        public static void UseUPSApplication(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(c => c.Run(async context =>
            {
                //Todo: move GlobalExceptionFilter here.
                var exception = context.Features
                    .Get<IExceptionHandlerPathFeature>()
                    .Error;
                var response = new ExceptionApiResult { Error = new ErrorInfo { Message = exception.Message }, __unauthorizedRequest = true, __traceId = "" };
                if (exception.GetType() == typeof(UPSExceptionAuthenticationFailed))
                    context.Response.StatusCode = 403;
                else
                    context.Response.StatusCode = 500;
                await context.Response.WriteAsJsonAsync(response);
            }));
            ConfigSwagger(app);
        }
        //*********************************************************************************************************
        /// <summary>
        /// congig swagger apps.
        /// </summary>
        /// <param name="app"></param>
        private static void ConfigSwagger(IApplicationBuilder app)
        {
            SwaggerOption swaggerOption = OptionService.GetOption<SwaggerOption>();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger(option =>
            {
                option.SerializeAsV2 = true;
                option.RouteTemplate = swaggerOption.JsonRoute;
            });

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/{swaggerOption.Name}/swagger.json", swaggerOption.Name);
            });
        }
        //*********************************************************************************************************
    }
}
