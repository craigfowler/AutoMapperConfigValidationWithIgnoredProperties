using AutoMapper;

namespace ConfigValidation;

public class MapSourceToDestinationWithGlobalIgnoreProfile : Profile
{
    public MapSourceToDestinationWithGlobalIgnoreProfile()
    {
        CreateMap<Source, Destination>();
        AddGlobalIgnore(nameof(IHasIgnoredProperty.IgnoredProperty));
    }
}