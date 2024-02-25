using MediatR;
using Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Commands.Requests;
using Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Queries.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.Tutorial.CQRS.Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    #region Manual CQRS
    //public class ProductsController(CreateProductCommandHandler createProductCommandHandler, DeleteProductCommandHandler deleteProductCommandHandler, GetAllProductQueryHandler getAllProductQueryHandler, GetByIdProductQueryHandler getByIdProductQueryHandler) : ControllerBase
    //{
    //    [HttpGet]
    //    public IActionResult Get([FromQuery] GetAllProductQueryRequest request)
    //        => Ok(getAllProductQueryHandler.GetAllProduct(request));

    //    [HttpGet("{ProductId}")]
    //    public IActionResult Get([FromRoute] GetByIdProductQueryRequest request)
    //        => Ok(getByIdProductQueryHandler.GetByIdProduct(request));

    //    [HttpPost]
    //    public IActionResult Post([FromBody] CreateProductCommandRequest request)
    //        => Ok(createProductCommandHandler.CreateProduct(request));

    //    [HttpDelete("{ProductId}")]
    //    public IActionResult Delete([FromRoute] DeleteProductCommandRequest request)
    //        => Ok(deleteProductCommandHandler.DeleteProduct(request));
    //} 
    #endregion
    #region MediatR CQRS
    public class ProductsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] GetAllProductQueryRequest request)
            => Ok(mediator.Send(request));

        [HttpGet("{ProductId}")]
        public IActionResult Get([FromRoute] GetByIdProductQueryRequest request)
            => Ok(mediator.Send(request));

        [HttpPost]
        public IActionResult Post([FromBody] CreateProductCommandRequest request)
            => Ok(mediator.Send(request));

        [HttpDelete("{ProductId}")]
        public IActionResult Delete([FromRoute] DeleteProductCommandRequest request)
            => Ok(mediator.Send(request));
    }
    #endregion
}
