using ExampleVerticalSliceArchteture.Api.Infrastructure;
using ExampleVerticalSliceArchteture.Api.Shared;
using Mapster;
using MediatR;
using System.Diagnostics.Metrics;

namespace ExampleVerticalSliceArchteture.Api.Features.Product.UpdateProduct
{
    public class UpdateProductHandler(AppDbContext context) : IRequestHandler<UpdateProductCommand, ServiceResponse>
    {
        public async Task<ServiceResponse> Handle(UpdateProductCommand productRequest, CancellationToken cancellationToken)
        {
            var product = productRequest.Adapt<Domain.Product>();
            context.Products.Update(product);
            await context.SaveChangesAsync(cancellationToken);
            return new ServiceResponse(true, "Updated");
        }
    }
}
