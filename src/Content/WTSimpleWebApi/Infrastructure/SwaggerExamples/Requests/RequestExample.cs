using Swashbuckle.AspNetCore.Filters;
using WTSimpleWebApi.Contract.V1.Requests;

namespace WTSimpleWebApi.Infrastructure.SwaggerExamples.Requests
{
    public class RequestExample: IExamplesProvider<ErrorModel>
    {
        public ErrorModel GetExamples()
        {
            return new ErrorModel
            {
                FieldName="test",
                Message="test"
            };
        }
    }
}
