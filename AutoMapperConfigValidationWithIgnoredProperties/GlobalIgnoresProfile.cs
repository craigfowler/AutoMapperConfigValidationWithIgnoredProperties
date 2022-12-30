using AutoMapper;

namespace ConfigValidation;

public class GlobalIgnoresProfile : Profile
{
    public GlobalIgnoresProfile()
    {
        AddGlobalIgnore(nameof(IHasIgnoredProperty.IgnoredProperty));
    }
}