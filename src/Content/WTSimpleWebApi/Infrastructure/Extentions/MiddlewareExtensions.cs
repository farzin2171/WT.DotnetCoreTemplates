using Microsoft.AspNetCore.Builder;
using WTSimpleWebApi.Infrastructure.MiddleWares;

namespace WTSimpleWebApi.Infrastructure.Extentions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CustomExceptionMiddleware>();
        }
    }
}
