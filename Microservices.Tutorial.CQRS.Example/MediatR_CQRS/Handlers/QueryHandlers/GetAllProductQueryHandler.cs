using MediatR;
using Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Queries.Requests;
using Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Queries.Responses;
using Microservices.Tutorial.CQRS.Example.Modals;

namespace Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            return ApplicationDbContext.ProductList.Select(p => new GetAllProductQueryResponse
            {
                Id = p.Id,
                CreateTime = p.CreateTime,
                Name = p.Name,
                Price = p.Price,
                Quantity = p.Quantity,
            }).ToList();
        }
    }
}
