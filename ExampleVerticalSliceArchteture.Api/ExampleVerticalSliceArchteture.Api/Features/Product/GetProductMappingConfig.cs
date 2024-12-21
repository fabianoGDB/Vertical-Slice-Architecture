using Mapster;

namespace ExampleVerticalSliceArchteture.Api.Features.Product
{
    public class GetProductMappingConfig
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Domain.Product, GetProductResponse>()
                .Map(d => d.CategoryName, s => s.Category!.Name);
        }
    }
}
