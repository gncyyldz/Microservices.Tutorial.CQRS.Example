using MediatR;
using Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Commands.Responses;

namespace Microservices.Tutorial.CQRS.Example.MediatR_CQRS.Commands.Requests
{
    public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
    {
        public Guid ProductId { get; set; }
    }
}
