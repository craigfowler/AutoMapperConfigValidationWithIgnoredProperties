using AutoMapper;

namespace ConfigValidation;

public class SourceToDestinationProfile : Profile
{
    public SourceToDestinationProfile()
    {
        CreateMap<Source, Destination>();
    }
}
