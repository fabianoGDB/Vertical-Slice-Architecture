using ExampleVerticalSliceArchteture.Api.Shared;
using MediatR;

namespace ExampleVerticalSliceArchteture.Api.Features.Product.DeleteProduct
{
    public record DeleteProductCommand(int Id) : IRequest<ServiceResponse>
    {
    }
}
