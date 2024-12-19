using ExampleVerticalSliceArchteture.Api.Shared;
using MediatR;

namespace ExampleVerticalSliceArchteture.Api.Features.Product.UpdateProduct
{
    public class UpdateProductCommand(UpdateProductRequest request): IRequest<ServiceResponse>
    {
    }
}
