using MediatR;

namespace ExampleVerticalSliceArchteture.Api.Features.Product.GetProductById
{
    public record GetAllProductQuery(): IRequest<IList<GetProductResponse>>
    {
    }
}
