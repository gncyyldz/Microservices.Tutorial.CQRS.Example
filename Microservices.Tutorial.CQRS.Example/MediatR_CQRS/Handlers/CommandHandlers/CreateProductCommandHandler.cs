using MediatR;
using Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Commands.Requests;
using Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Commands.Responses;
using Microservices.Tutorial.CQRS.Example.Modals;

namespace Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            ApplicationDbContext.ProductList.Add(new()
            {
                Id = id,
                Name = request.Name,
                CreateTime = DateTime.Now,
                Price = request.Price,
                Quantity = request.Quantity
            });

            return new CreateProductCommandResponse
            {
                ProductId = id,
                IsSuccess = true
            };
        }
    }
}
