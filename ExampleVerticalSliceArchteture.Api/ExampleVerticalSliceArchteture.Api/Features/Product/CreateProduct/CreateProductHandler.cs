using ExampleVerticalSliceArchteture.Api.Infrastructure;
using ExampleVerticalSliceArchteture.Api.Shared;
using Mapster;
using MediatR;

namespace ExampleVerticalSliceArchteture.Api.Features.Product.CreateProduct
{
    public class CreateProductHandler(AppDbContext contex) : IRequestHandler<CreateProductCommand, ServiceResponse>
    {
        public async Task<ServiceResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = request.productRequest.Adapt<Domain.Product>();
            contex.Products.Add(product);
            await contex.SaveChangesAsync(cancellationToken);
            return new ServiceResponse(true, "Saved");
        }
    }
}
