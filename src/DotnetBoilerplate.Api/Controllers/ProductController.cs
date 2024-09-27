using Microsoft.AspNetCore.Mvc;

namespace DotnetBoilerplate.Api.Controllers
{
    [Route("/v1/[Controller]")]
    public class ProductController : Controller
    {
        [HttpGet]
        public async Task<string> GetAllProducts(CancellationToken cancellationToken)
        {
            return await Task.FromResult<string>("Ok");
        }
    }
}