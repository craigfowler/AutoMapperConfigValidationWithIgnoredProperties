using AutoMapper;

namespace ConfigValidation;

public class MapSourceToDestinationWithShouldMapPropertyProfile : Profile
{
    public MapSourceToDestinationWithShouldMapPropertyProfile()
    {
        ShouldMapProperty = p => !IgnoredPropertySpecification.IsIgnoredProperty(p);
        CreateMap<Source, Destination>();
    }
}