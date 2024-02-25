using Microservices.Tutorial.CQRS.Example.Manual_CQRS.Commands.Requests;
using Microservices.Tutorial.CQRS.Example.Manual_CQRS.Commands.Responses;
using Microservices.Tutorial.CQRS.Example.Modals;

namespace Microservices.Tutorial.CQRS.Example.Manual_CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler
    {
        public DeleteProductCommandResponse DeleteProduct(DeleteProductCommandRequest request)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(p => p.Id == request.ProductId);
            if (product != null)
            {
                ApplicationDbContext.ProductList.Remove(product);
            }
            return new DeleteProductCommandResponse()
            {
                IsSuccess = true,
            };
        }
    }
}
