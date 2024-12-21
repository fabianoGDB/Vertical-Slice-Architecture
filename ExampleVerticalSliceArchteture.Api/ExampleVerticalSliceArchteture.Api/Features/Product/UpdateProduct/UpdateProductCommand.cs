using ExampleVerticalSliceArchteture.Api.Shared;
using MediatR;

namespace ExampleVerticalSliceArchteture.Api.Features.Product.UpdateProduct
{
    public record UpdateProductCommand(UpdateProductRequest request): IRequest<ServiceResponse>
    {
    }
}
