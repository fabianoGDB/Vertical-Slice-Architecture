using MediatR;

namespace ExampleVerticalSliceArchteture.Api.Features.Product
{
    public record GetAllProductQuery(): IRequest<IEnumerable<GetProductResponse>>
    {
    }
}
