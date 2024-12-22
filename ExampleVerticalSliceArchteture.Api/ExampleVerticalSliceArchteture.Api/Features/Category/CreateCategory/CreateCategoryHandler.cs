using ExampleVerticalSliceArchteture.Api.Features.Category.CreateProduct;
using ExampleVerticalSliceArchteture.Api.Infrastructure;
using ExampleVerticalSliceArchteture.Api.Shared;
using Mapster;
using MediatR;

namespace ExampleVerticalSliceArchteture.Api.Features.Category.CreateCategory
{
    public class CreateCategoryHandler(AppDbContext contex) : IRequestHandler<CreateCategoryCommand, ServiceResponse>
    {
        public async Task<ServiceResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = request.categoryRequest.Adapt<Domain.Category>();
            contex.Categories.Add(category);
            await contex.SaveChangesAsync(cancellationToken);
            return new ServiceResponse(true, "Saved");
        }
    }
}
