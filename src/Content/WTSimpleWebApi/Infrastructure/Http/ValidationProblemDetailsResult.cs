using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WTSimpleWebApi.Infrastructure.Extentions;

namespace WTSimpleWebApi.Infrastructure.Http
{
    public class ValidationProblemDetailsResult : IActionResult
    {
        public async Task ExecuteResultAsync(ActionContext actionContext)
        {
            await actionContext.HttpContext.Response.WriteBadRequestResponseAsync(actionContext.ModelState);
        }
    }
}
