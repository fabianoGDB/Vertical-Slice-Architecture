using ExampleVerticalSliceArchteture.Api.Features.Category.CreateCategory;
using ExampleVerticalSliceArchteture.Api.Shared;
using MediatR;

namespace ExampleVerticalSliceArchteture.Api.Features.Category.CreateProduct
{
    public record CreateCategoryCommand(CreateCategoryRequest categoryRequest) : IRequest<ServiceResponse>
    {
    }
}
