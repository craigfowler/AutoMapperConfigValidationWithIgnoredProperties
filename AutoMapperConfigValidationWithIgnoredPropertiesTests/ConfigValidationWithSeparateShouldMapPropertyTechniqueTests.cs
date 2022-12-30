using AutoMapper;
using NUnit.Framework;

namespace ConfigValidation;

public class ConfigValidationWithSeparateShouldMapPropertyTechniqueTests : TestBase
{
    protected override MapperConfiguration GetConfig()
        => new MapperConfiguration(cfg => {
            cfg.AddProfile<SourceToDestinationProfile>();
            cfg.AddProfile<ShouldMapPropertyProfile>();
        });
}