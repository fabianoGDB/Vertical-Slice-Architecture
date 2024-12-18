using ExampleVerticalSliceArchteture.Api.Shared;
using MediatR;

namespace ExampleVerticalSliceArchteture.Api.Features.Product.CreateProduct
{
    public record CreateProductCommand(CreateProductRequest productRequest) : IRequest<ServiceResponse>
    {
    }
}
