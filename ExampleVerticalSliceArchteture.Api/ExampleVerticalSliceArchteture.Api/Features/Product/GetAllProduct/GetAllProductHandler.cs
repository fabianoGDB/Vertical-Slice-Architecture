using ExampleVerticalSliceArchteture.Api.Infrastructure;
using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ExampleVerticalSliceArchteture.Api.Features.Product.GetAllProduct
{
    public class GetAllProductHandler(AppDbContext context) : IRequestHandler<GetAllProductQuery, IEnumerable<GetProductResponse>>
    {
        public async Task<IEnumerable<GetProductResponse>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var products = await context.Products.ToListAsync(cancellationToken);
            return products.Adapt<IEnumerable<GetProductResponse>>();
        }
    }
}
