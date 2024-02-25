namespace Microservices.Tutorial.CQRS.Example.Manual_CQRS.Commands.Requests
{
    public class CreateProductCommandRequest
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
