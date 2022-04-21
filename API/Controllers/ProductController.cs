using API.Common;
using Application.Modules.Product.Models;
using Application.Modules.Product.Queries;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(List<ProductDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<ProductDto>>> GetProductsDetails()
        {
            var productDetails = await Mediator.Send(new GetProductListQuery());
			if (!productDetails.Any())
			{
                return NoContent();
            }

            return Ok(productDetails);
        }
    }
}
