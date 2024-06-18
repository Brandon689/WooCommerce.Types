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

    public WCProduct ConvertSourceToDestination(WCExternalProduct source)
    {
        return _mapper.Map<WCProduct>(source);
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

    public WCProduct ConvertToProduct(WCExternalProduct source)
    {
        return _mapper.Map<WCProduct>(source);
    }

    public WCExternalProduct ConvertToExternalProduct(WCProduct source)
    {
        return _mapper.Map<WCExternalProduct>(source);
    }

    public ProductVariation ConvertToProductVariations(ExternalProductVariation source)
    {
        return _mapper.Map<ProductVariation>(source);
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
        CreateMap<WCExternalProduct, WCProduct>();
        CreateMap<ExternalProductAttribute, ProductAttribute>();
        CreateMap<ExternalProductVariation, ProductVariation>();
        CreateMap<ExternalImage, WCImage>();
        CreateMap<ExternalProductMetadata, ProductMetadata>();
        CreateMap<ExternalDimensions, Dimensions>();
        CreateMap<ExternalCategory, WCCategory>();
        CreateMap<ExternalLinks, WCLinks>();
        CreateMap<ExternalSelf, WCSelf>();
        CreateMap<ExternalCollection, WCCollection>();

        CreateMap<WCProduct, WCExternalProduct>();
        CreateMap<ProductAttribute, ExternalProductAttribute>();
        CreateMap<ProductVariation, ExternalProductVariation>();
        CreateMap<WCImage, ExternalImage>();
        CreateMap<ProductMetadata, ExternalProductMetadata>();
        CreateMap<Dimensions, ExternalDimensions>();
        CreateMap<WCCategory, ExternalCategory>();
        CreateMap<WCLinks, ExternalLinks>();
        CreateMap<WCSelf, ExternalSelf>();
        CreateMap<WCCollection, ExternalCollection>();


        CreateMap<ExternalProductVariationsRequest, ProductVariationsRequest>();
        CreateMap<ExternalProductVariation, ProductVariation>();
        CreateMap<ExternalVariationAttribute, VariationAttribute>();

        CreateMap<ProductVariationsRequest, ExternalProductVariationsRequest>();
        CreateMap<ProductVariation, ExternalProductVariation>();
        CreateMap<VariationAttribute, ExternalVariationAttribute>();
    }
}
