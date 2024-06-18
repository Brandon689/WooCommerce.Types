using AutoMapper;
using WooCommerceAPI.Models.Services.Foundations.ExternalProducts;
using WooCommerceAPI.Models.Services.Foundations.ExternalProductVariations;
using WooCommerceAPI.Models.Services.Foundations.Products;
using WooCommerceAPI.Models.Services.Foundations.ProductVariations;

namespace WooCommerce.Types.Services;

public class Converter
{
    private readonly IMapper _mapper;

    public Converter()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<ExtProfile>());
        _mapper = config.CreateMapper();
    }

    public Product ConvertSourceToDestination(ExternalProduct source)
    {
        return _mapper.Map<Product>(source);
    }
}

public class WCMapper
{
    private readonly IMapper _mapper;

    public WCMapper()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<ExtProfile>());
        _mapper = config.CreateMapper();
    }

    public Product ConvertToProduct(ExternalProduct source)
    {
        return _mapper.Map<Product>(source);
    }

    public ExternalProduct ConvertToExternalProduct(Product source)
    {
        return _mapper.Map<ExternalProduct>(source);
    }

    public ExternalProductVariationsRequest ConvertToExternalProductVariations(ProductVariationsRequest source)
    {
        return _mapper.Map<ExternalProductVariationsRequest>(source);
    }
}

public class ExtProfile : Profile
{
    public ExtProfile()
    {
        CreateMap<ExternalProduct, Product>();
        CreateMap<ExternalProductAttribute, ProductAttribute>();
        CreateMap<ExternalProductVariation, ProductVariation>();
        CreateMap<ExternalImage, Image>();
        CreateMap<ExternalProductMetadata, ProductMetadata>();
        CreateMap<ExternalDimensions, Dimensions>();
        CreateMap<ExternalCategory, Category>();
        CreateMap<ExternalLinks, Links>();
        CreateMap<ExternalSelf, Self>();
        CreateMap<ExternalCollection, Collection>();

        CreateMap<Product, ExternalProduct>();
        CreateMap<ProductAttribute, ExternalProductAttribute>();
        CreateMap<ProductVariation, ExternalProductVariation>();
        CreateMap<Image, ExternalImage>();
        CreateMap<ProductMetadata, ExternalProductMetadata>();
        CreateMap<Dimensions, ExternalDimensions>();
        CreateMap<Category, ExternalCategory>();
        CreateMap<Links, ExternalLinks>();
        CreateMap<Self, ExternalSelf>();
        CreateMap<Collection, ExternalCollection>();


        CreateMap<ExternalProductVariationsRequest, ProductVariationsRequest>();
        CreateMap<ExternalProductVariation, ProductVariation>();
        CreateMap<ExternalVariationAttribute, VariationAttribute>();

        CreateMap<ProductVariationsRequest, ExternalProductVariationsRequest>();
        CreateMap<ProductVariation, ExternalProductVariation>();
        CreateMap<VariationAttribute, ExternalVariationAttribute>();
    }
}
