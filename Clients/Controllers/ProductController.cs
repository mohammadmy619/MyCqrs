using CoreLayear.Features.Products.Commends.CreateProduct;
using CoreLayear.Features.Products.Commends.DeleteProduct;
using CoreLayear.Features.Products.Commends.EditProduct;
using CoreLayear.Features.Products.Queries.ProductDetail;
using CoreLayear.Features.Products.Queries.ProductList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Clients.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region constructor

        private readonly IMediator _mediator;
        


        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #endregion

        #region GetProductDetail
        [HttpGet("{ID}", Name = "GetProductDetail")]
        [ProducesResponseType(typeof(ProductDetailDto), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> GetProductDetail(long ID)
        {
            var query = new GetProductDetial(ID);


            var Product = await _mediator.Send(query);

            return Ok(Product);
        }
        #endregion

        #region GetProductList

        [HttpGet(Name = "GetProductList")]
        [ProducesResponseType(typeof(IEnumerable<ProductListDto>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetProductList()
        {

            var ProductList = await _mediator.Send(new GetProductList());

            return Ok(ProductList);
        }
        #endregion

        #region AddProduct

        [HttpPost(Name = "AddProduct")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<long>> AddProduct([FromBody] AddProduct Product)
        {
            var result = await _mediator.Send(Product);

            return RedirectToAction("GetProductDetail", new { ID = result });
        }


        #endregion

        #region EditProduct
        [HttpPut(Name = "EditProduct")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<long>> EditProduct([FromBody] EditProductCommand Product)
        {

            await _mediator.Send(Product);


            return Ok("Edit is ok");

            
        }

        #endregion

        #region DeleteProduct

        [HttpDelete(Name = "DeleteProduct")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<long>> DeleteProduct(long ID)
        {
            var query = new DeleteProductCommand(ID);
            

            var result = await _mediator.Send(query);
            return Ok();
        }

        #endregion

      

    }
}
