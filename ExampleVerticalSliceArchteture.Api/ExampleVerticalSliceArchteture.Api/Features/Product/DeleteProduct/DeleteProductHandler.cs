using ExampleVerticalSliceArchteture.Api.Infrastructure;
using ExampleVerticalSliceArchteture.Api.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ExampleVerticalSliceArchteture.Api.Features.Product.DeleteProduct
{
    public class DeleteProductHandler(AppDbContext context) : IRequestHandler<DeleteProductCommand, ServiceResponse>
    {
        public async Task<ServiceResponse> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await context.Products.FirstOrDefaultAsync(p => p.Id == request.Id);
            if (product != null)
            {
                context.Products.Remove(product);
            }
            await context.SaveChangesAsync(cancellationToken);
            return new ServiceResponse(true, "Deleted");
        }
    }
}
