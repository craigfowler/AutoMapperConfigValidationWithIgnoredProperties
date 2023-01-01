using AutoMapper;

namespace ConfigValidation;

public class ConfigValidationWithRootGlobalIgnoreTechniqueTests : TestBase
{
    protected override MapperConfiguration GetConfig()
        => new MapperConfiguration(cfg => {
            cfg.AddProfile<SourceToDestinationProfile>();
            cfg.AddGlobalIgnore(nameof(IHasIgnoredProperty.IgnoredProperty));
        });
}