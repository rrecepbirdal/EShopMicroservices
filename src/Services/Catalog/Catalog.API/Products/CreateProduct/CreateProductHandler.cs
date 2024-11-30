using MediatR;

namespace Catalog.API.Products.CreateProduct
{

    public record CreateProductCommand(Guid Id, string Name, List<string> Category , string Description,string ImageFile, decimal Price)
        :IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    internal class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            //Business logic here.
            throw new NotImplementedException();
        }
    }
}
