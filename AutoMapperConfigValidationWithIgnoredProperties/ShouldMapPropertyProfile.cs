using AutoMapper;

namespace ConfigValidation;

public class ShouldMapPropertyProfile : Profile
{
    public ShouldMapPropertyProfile()
    {
        ShouldMapProperty = p => !IgnoredPropertySpecification.IsIgnoredProperty(p);
    }
}
