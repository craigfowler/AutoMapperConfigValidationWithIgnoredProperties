using AutoMapper;
using NUnit.Framework;

namespace ConfigValidation;

public class ConfigValidationWithGlobalIgnoreTechniqueTests : TestBase
{
    protected override MapperConfiguration GetConfig()
        => new MapperConfiguration(cfg => cfg.AddProfile<MapSourceToDestinationWithGlobalIgnoreProfile>());
}