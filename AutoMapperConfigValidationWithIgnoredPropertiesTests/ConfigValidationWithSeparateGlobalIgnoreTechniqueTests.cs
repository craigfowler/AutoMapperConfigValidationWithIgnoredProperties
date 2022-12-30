using AutoMapper;

namespace ConfigValidation;

public class ConfigValidationWithSeparateGlobalIgnoreTechniqueTests : TestBase
{
    protected override MapperConfiguration GetConfig()
        => new MapperConfiguration(cfg => {
            cfg.AddProfile<SourceToDestinationProfile>();
            cfg.AddProfile<GlobalIgnoresProfile>();
        });
}