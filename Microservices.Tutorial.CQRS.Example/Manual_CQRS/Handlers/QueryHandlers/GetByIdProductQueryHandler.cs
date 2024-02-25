using Microservices.Tutorial.CQRS.Example.Manual_CQRS.Queries.Requests;
using Microservices.Tutorial.CQRS.Example.Manual_CQRS.Queries.Responses;
using Microservices.Tutorial.CQRS.Example.Modals;

namespace Microservices.Tutorial.CQRS.Example.Manual_CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler
    {
        public GetByIdProductQueryResponse GetByIdProduct(GetByIdProductQueryRequest request)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(p => p.Id == request.ProductId);
            return new GetByIdProductQueryResponse
            {
                Id = product.Id,
                CreateTime = product.CreateTime,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
            };
        }
    }
}
