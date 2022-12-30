using AutoMapper;
using NUnit.Framework;

namespace ConfigValidation;

public class ConfigValidationWithShouldMapPropertyTechniqueTests : TestBase
{
    protected override MapperConfiguration GetConfig()
        => new MapperConfiguration(cfg => cfg.AddProfile<MapSourceToDestinationWithShouldMapPropertyProfile>());
}