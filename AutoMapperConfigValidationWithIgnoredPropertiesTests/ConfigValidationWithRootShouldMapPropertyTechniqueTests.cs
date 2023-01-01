using AutoMapper;
using NUnit.Framework;

namespace ConfigValidation;

public class ConfigValidationWithRootShouldMapPropertyTechniqueTests : TestBase
{
    protected override MapperConfiguration GetConfig()
        => new MapperConfiguration(cfg => {
            cfg.AddProfile<SourceToDestinationProfile>();
            cfg.ShouldMapProperty = p => !IgnoredPropertySpecification.IsIgnoredProperty(p);
        });
}