using MediatR;

namespace ExampleVerticalSliceArchteture.Api.Features.Product.GetProductById
{
    public record GetProductByIdQuery(int Id): IRequest<GetProductResponse>
    {
    }
}
